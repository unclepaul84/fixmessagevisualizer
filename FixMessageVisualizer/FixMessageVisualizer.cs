//Sample license text.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace FixMessageVisualizer
{
    public class FixMessageVisualizer
    {

        private string _message;

        private IFixDictionarySource _dicSource;

        public FixMessageVisualizer(string message, IFixDictionarySource source)
        {
            QuickFix.DataDictionary.DataDictionary dict = new QuickFix.DataDictionary.DataDictionary();

            _message = message;

            _dicSource = source;

        }

        public QuickFix.FixMessageDescriptor GetDescriptor()
        {
            try
            {
                QuickFix.Message msg = new QuickFix.Message();

                msg.FromString(_message, false, null, null);

                string beginString = msg.Header.GetField(QuickFix.Fields.Tags.BeginString);

                QuickFix.DataDictionary.DataDictionary dict = _dicSource.GetDictionaryForBeginString(beginString);


                QuickFix.Message theMsg = new QuickFix.Message();

                theMsg.FixMessageDescriptorEnabled = true;

                theMsg.FromString(_message, true, dict, dict);

                return theMsg.GetDescriptor();


            }
            catch (Exception ex)
            {
                Trace.TraceError("{0}: Error while parsing fix message: {1}", this, ex);

                return null;
            }
        }

        public IList<FixMesageValidationErrorDescriptor> GetValidationErrors()
        {
            try
            {
                QuickFix.Message msg = new QuickFix.Message();

                msg.FromString(_message, false, null, null);

                string beginString = msg.Header.GetField(QuickFix.Fields.Tags.BeginString);
                string msgType = msgType = msg.Header.GetField(QuickFix.Fields.Tags.MsgType);
                QuickFix.DataDictionary.DataDictionary dict = _dicSource.GetDictionaryForBeginString(beginString);


                dict.Validate(msg, beginString, msgType);
                return null;
            }
            catch (Exception ex)
            {
                //TODO: create a validation method on fix dictionary that retuns a list of errors instead of just throwing on the first one
                FixMesageValidationErrorDescriptor descr = new FixMesageValidationErrorDescriptor();

                descr.Message = ex.Message;

                return new List<FixMesageValidationErrorDescriptor>(new FixMesageValidationErrorDescriptor[] { descr });

            }
        }

        public class FixMesageValidationErrorDescriptor
        {
            public string Message { get; set; }

            int? Tag { get; set; } //if tag is not set
        }
    }
}

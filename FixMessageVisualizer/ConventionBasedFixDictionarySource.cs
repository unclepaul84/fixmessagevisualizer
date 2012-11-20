using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace FixMessageVisualizer
{
    /// <summary>
    /// looks for quickfix xml dictionary files in a specified directory, by removing all '.'s in the begin string and appeding '.xml'
    /// </summary>
    public class ConventionBasedFixDictionarySource : IFixDictionarySource
    {
        #region IFixDictionarySource Members

        private string _directory;


        public ConventionBasedFixDictionarySource(string directory)
        {
            if (!Directory.Exists(directory))
            {

                Trace.TraceWarning("{0} could not find directory for quickfix dict files at: {1}", this, directory);

                throw new DirectoryNotFoundException("Must provide an existing directory where fix dictionary files are located!");
            }

            _directory = directory;

        }

        /// <summary>
        /// the directory will be set to AppDomain.CurrentDomain.BaseDirectory
        /// </summary>
        public ConventionBasedFixDictionarySource()
        {
            _directory = AppDomain.CurrentDomain.BaseDirectory;

        }

        public QuickFix.DataDictionary.DataDictionary GetDictionaryForBeginString(string beginString)
        {

            string filePath = Path.Combine(_directory, string.Format("{0}.xml", beginString.Replace(".", "")));



            if (File.Exists(filePath))
            {

                return new QuickFix.DataDictionary.DataDictionary(filePath);
            }
            else
            {
                Trace.TraceWarning("{0}: could not find quickfix dict file at: {1}", this, filePath);

                return null;

            }
        }

        #endregion
    }
}

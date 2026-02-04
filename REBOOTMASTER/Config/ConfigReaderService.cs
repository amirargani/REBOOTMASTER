using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace REBOOTMASTER.Config
{
    public class ConfigReaderService
    {
        // Properties
        // Configuration object
        public static Configuration? configService;

        // ConfigService.dll file name
        private static string _fileNameconfigService = "ConfigService.dll";
        // Get or set ConfigService.dll file name
        public static string FileName
        {
            get
            {
                return _fileNameconfigService;
            }
            set
            {
                configService = null;
                _fileNameconfigService = value;
            }
        }
    }
}
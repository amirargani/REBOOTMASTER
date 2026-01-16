using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace REBOOTMASTER.Config
{
    internal class ConfigReaderService
    {

        public static Configuration? configService;

        private static string _fileNameconfigService = "ConfigService.dll";

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
﻿using System.IO;
using System.Xml.Serialization;
using BaseLibS.Param;

namespace PluginInterop
{
    public static class ParametersExtensions
    {
        public static void ToFile(this Parameters param, string paramFile)
        {
            using (var f = new StreamWriter(paramFile))
            {
                param.Convert(ParamUtils.ConvertBack);
                var serializer = new XmlSerializer(param.GetType());
                serializer.Serialize(f, param);
            }
        }
    }
}
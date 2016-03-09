using System.Configuration;
using System.IO;

namespace JiebaNet.Segmenter
{
	public class ConfigManager
	{
		public static string MainDictFile
		{
			get { return ConfigurationManager.AppSettings ["MainDictFile"] ?? Path.Combine ("Resources", "dict.txt"); }
		}

		public static string ProbTransFile
		{
			get { return ConfigurationManager.AppSettings ["ProbTransFile"] ?? Path.Combine ("Resources", "prob_trans.json"); }
		}

		public static string ProbEmitFile
		{
			get { return ConfigurationManager.AppSettings ["ProbEmitFile"] ?? Path.Combine ("Resources", "prob_emit.json"); }
		}

		public static string PosProbStartFile
		{
			get { return ConfigurationManager.AppSettings ["PosProbStartFile"] ?? Path.Combine ("Resources", "pos_prob_start.json"); }
		}

		public static string PosProbTransFile
		{
			get { return ConfigurationManager.AppSettings ["PosProbTransFile"] ?? Path.Combine ("Resources", "pos_prob_trans.json"); }
		}

		public static string PosProbEmitFile
		{
			get { return ConfigurationManager.AppSettings ["PosProbEmitFile"] ?? Path.Combine ("Resources", "pos_prob_emit.json"); }
		}

		public static string CharStateTabFile
		{
			get { return ConfigurationManager.AppSettings ["CharStateTabFile"] ?? Path.Combine ("Resources", "char_state_tab.json"); }
		}
	}
}
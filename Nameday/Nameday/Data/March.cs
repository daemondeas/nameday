using System;

namespace Nameday.Data
{
    public class March : Month
    {
        public March()
        {
        }

        public override int NumberOfDays => 31;

        public override string Name => "mars";

        protected override string[][] Names => new[] {
				new [] { "Albin", "Elvira" },
				new [] { "Ernst", "Erna" },
				new [] { "Gunborg", "Gunvor" },
				new [] { "Adrian", "Adriana" },
				new [] { "Tora", "Tove" },
				new [] { "Ebba", "Ebbe" },
				new [] { "Camilla" },
				new [] { "Siv" },
				new [] { "Torbjörn", "Torleif" },
				new [] { "Edla", "Ada" },
				new [] { "Edvin", "Egon" },
				new [] { "Viktoria" },
				new [] { "Greger" },
				new [] { "Matilda", "Maud" },
				new [] { "Kristoffer", "Christel" },
				new [] { "Herbert", "Gilbert" },
				new [] { "Gertrud" },
				new [] { "Edvard", "Edmund" },
				new [] { "Josef", "Josefina" },
				new [] { "Joakim", "Kim" },
				new [] { "Bengt" },
				new [] { "Kennet", "Kent" },
				new [] { "Gerda", "Gerd" },
				new [] { "Gabriel", "Rafael" },
 				Array.Empty<string>(),
				new [] { "Emanuel" },
				new [] { "Rudolf", "Ralf" },
				new [] { "Malkolm", "Morgan" },
				new [] { "Jonas", "Jens" },
				new [] { "Holger", "Holmfrid" },
				new [] { "Ester" }
		};
    }
}

using System;

namespace Nameday.Data
{
    public class February : Month
    {
        public February()
        {
        }

        public override int NumberOfDays => 29;

        public override string Name => "februari";

        protected override string[][] Names => new[] {
				new [] { "Max", "Maximilian" },
 				Array.Empty<string>(),
				new [] { "Disa", "Hjördis" },
				new [] { "Ansgar", "Anselm" },
				new [] { "Agata", "Agda" },
				new [] { "Dorotea", "Doris" },
				new [] { "Rikard", "Dick" },
				new [] { "Berta", "Bert" },
				new [] { "Fanny", "Franciska" },
				new [] { "Iris" },
				new [] { "Yngve", "Inge" },
				new [] { "Evelina", "Evy" },
				new [] { "Agne", "Ove" },
				new [] { "Valentin" },
				new [] { "Sigfrid" },
				new [] { "Julia", "Julius" },
				new [] { "Alexandra", "Sandra" },
				new [] { "Frida", "Fritiof" },
				new [] { "Gabriella", "Ella" },
				new [] { "Vivianne" },
				new [] { "Hilding" },
				new [] { "Pia" },
				new [] { "Torsten", "Torun" },
				new [] { "Mattias", "Mats" },
				new [] { "Sigvard", "Sivert" },
				new [] { "Torgny", "Torkel" },
				new [] { "Lage" },
				new [] { "Maria" },
 				Array.Empty<string>()
		};
    }
}

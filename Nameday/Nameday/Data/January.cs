using System;

namespace Nameday.Data
{
    public class January : Month
    {
        public override int NumberOfDays => 31;

        public override string Name => "januari";

        protected override string[][] Names => new[] {
            Array.Empty<string>(),
			new [] { "Svea" },
			new [] { "Alfred", "Alfrida" },
			new [] { "Rut" },
			new [] { "Hanna", "Hannele" },
			new [] { "Kasper", "Melker", "Baltsar" },
			new [] { "August", "Augusta" },
			new [] { "Erland" },
			new [] { "Gunnar", "Gunder" },
			new [] { "Sigurd", "Sigbritt" },
			new [] { "Jan", "Jannike" },
			new [] { "Frideborg", "Fridolf" },
			new [] { "Knut" },
			new [] { "Felix", "Felicia" },
			new [] { "Laura", "Lorentz" },
			new [] { "Hjalmar", "Helmer" },
			new [] { "Anton", "Tony" },
			new [] { "Hilda", "Hildur" },
			new [] { "Henrik" },
			new [] { "Fabian", "Sebastian" },
			new [] { "Agnes", "Agneta" },
			new [] { "Vincent", "Viktor" },
			new [] { "Frej", "Freja" },
			new [] { "Erika" },
			new [] { "Paul", "Pål" },
			new [] { "Bodil", "Boel" },
			new [] { "Göte", "Göta" },
			new [] { "Karl", "Karla" },
			new [] { "Diana" },
			new [] { "Gunilla", "Gunhild" },
			new [] { "Ivar", "Joar" },
		};
    }
}

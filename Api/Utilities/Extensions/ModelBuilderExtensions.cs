using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Utilities.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void GeolocationSeeding(this ModelBuilder builder)
        {
            #region Continentals

            builder.Entity<Continental>().HasData(
                new Continental() {Id = 1, Name = "Africa"},
                new Continental() {Id = 2, Name = "Americas"},
                new Continental() {Id = 3, Name = "Antarctica"},
                new Continental() {Id = 4, Name = "Asia"},
                new Continental() {Id = 5, Name = "Europe"},
                new Continental() {Id = 6, Name = "Oceania"}
            );

            #endregion

            #region Regions

            builder.Entity<Region>().HasData(
                new Region() {Id = 1, Name = "Central Africa", ContinentalId = 1},
                new Region() {Id = 2, Name = "Eastern Africa", ContinentalId = 1},
                new Region() {Id = 3, Name = "Indian Ocean", ContinentalId = 1},
                new Region() {Id = 4, Name = "Northern Africa", ContinentalId = 1},
                new Region() {Id = 5, Name = "Southern Africa", ContinentalId = 1},
                new Region() {Id = 6, Name = "Western Africa", ContinentalId = 1},
                new Region() {Id = 7, Name = "Central America", ContinentalId = 2},
                new Region() {Id = 8, Name = "North America", ContinentalId = 2},
                new Region() {Id = 9, Name = "South America", ContinentalId = 2},
                new Region() {Id = 10, Name = "West Indies", ContinentalId = 2},
                new Region() {Id = 11, Name = "Atlantic Ocean", ContinentalId = 3},
                new Region() {Id = 12, Name = "Central Asia", ContinentalId = 4},
                new Region() {Id = 13, Name = "East Asia", ContinentalId = 4},
                new Region() {Id = 14, Name = "Northern Asia", ContinentalId = 4},
                new Region() {Id = 15, Name = "South Asia", ContinentalId = 4},
                new Region() {Id = 16, Name = "South West Asia", ContinentalId = 4},
                new Region() {Id = 17, Name = "Central Europe", ContinentalId = 5},
                new Region() {Id = 18, Name = "Eastern Europe", ContinentalId = 5},
                new Region() {Id = 19, Name = "Northern Europe", ContinentalId = 5},
                new Region() {Id = 20, Name = "South East Europe", ContinentalId = 5},
                new Region() {Id = 21, Name = "South West Europe", ContinentalId = 5},
                new Region() {Id = 22, Name = "Southern Europe", ContinentalId = 5},
                new Region() {Id = 23, Name = "Western Europe", ContinentalId = 5},
                new Region() {Id = 24, Name = "Pacific", ContinentalId = 6}
            );

            #endregion
            
            #region Countries

            builder.Entity<Country>().HasData(
                new Country()
                {
                    Id = 108,
                    Name = "Burundi", RegionId = 1, Alpha2Code = "BI", Alpha3Code = "BDI",
                    UnCode = "108"
                },
                new Country()
                {
                    Id = 148,
                    Name = "Chad", RegionId = 1, Alpha2Code = "TD", Alpha3Code = "TCD",
                    UnCode = "148"
                },
                new Country()
                {
                    Id = 178,
                    Name = "Congo, Republic of the", RegionId = 1, Alpha2Code = "CG",
                    Alpha3Code = "COG", UnCode = "178"
                },
                new Country()
                {
                    Id = 180,
                    Name = "Congo, Democratic Republic of the", RegionId = 1, Alpha2Code = "CD",
                    Alpha3Code = "COD", UnCode = "180"
                },
                new Country()
                {
                    Id = 140,
                    Name = "Central African Republic", RegionId = 1, Alpha2Code = "CF",
                    Alpha3Code = "CAF", UnCode = "140"
                },
                new Country()
                {
                    Id = 646,
                    Name = "Rwanda", RegionId = 1, Alpha2Code = "RW", Alpha3Code = "RWA",
                    UnCode = "646"
                },
                new Country()
                {
                    Id = 262,
                    Name = "Djibouti", RegionId = 2, Alpha2Code = "DJ", Alpha3Code = "DJI",
                    UnCode = "262"
                },
                new Country()
                {
                    Id = 232,
                    Name = "Eritrea", RegionId = 2, Alpha2Code = "ER", Alpha3Code = "ERI",
                    UnCode = "232"
                },
                new Country()
                {
                    Id = 231,
                    Name = "Ethiopia", RegionId = 2, Alpha2Code = "ET", Alpha3Code = "ETH",
                    UnCode = "231"
                },
                new Country()
                {
                    Id = 404,
                    Name = "Kenya", RegionId = 2, Alpha2Code = "KE", Alpha3Code = "KEN",
                    UnCode = "404"
                },
                new Country()
                {
                    Id = 706,
                    Name = "Somalia", RegionId = 2, Alpha2Code = "SO", Alpha3Code = "SOM",
                    UnCode = "706"
                },
                new Country()
                {
                    Id = 728,
                    Name = "South Sudan", RegionId = 2, Alpha2Code = "SS", Alpha3Code = "SSD",
                    UnCode = "728"
                },
                new Country()
                {
                    Id = 834,
                    Name = "Tanzania, United Republic of", RegionId = 2, Alpha2Code = "TZ",
                    Alpha3Code = "TZA", UnCode = "834"
                },
                new Country()
                {
                    Id = 800,
                    Name = "Uganda", RegionId = 2, Alpha2Code = "UG", Alpha3Code = "UGA",
                    UnCode = "800"
                },
                new Country()
                {
                    Id = 174,
                    Name = "Comoros", RegionId = 3, Alpha2Code = "KM", Alpha3Code = "COM",
                    UnCode = "174"
                },
                new Country()
                {
                    Id = 450,
                    Name = "Madagascar", RegionId = 3, Alpha2Code = "MG", Alpha3Code = "MDG",
                    UnCode = "450"
                },
                new Country()
                {
                    Id = 175,
                    Name = "Mayotte", RegionId = 3, Alpha2Code = "YT", Alpha3Code = "MYT",
                    UnCode = "175"
                },
                new Country()
                {
                    Id = 480,
                    Name = "Mauritius", RegionId = 3, Alpha2Code = "MU", Alpha3Code = "MUS",
                    UnCode = "480"
                },
                new Country()
                {
                    Id = 638,
                    Name = "Réunion", RegionId = 3, Alpha2Code = "RE", Alpha3Code = "REU",
                    UnCode = "638"
                },
                new Country()
                {
                    Id = 690,
                    Name = "Seychelles", RegionId = 3, Alpha2Code = "SC", Alpha3Code = "SYC",
                    UnCode = "690"
                },
                new Country()
                {
                    Id = 012,
                    Name = "Algeria", RegionId = 4, Alpha2Code = "DZ", Alpha3Code = "DZA",
                    UnCode = "012"
                },
                new Country()
                {
                    Id = 818,
                    Name = "Egypt", RegionId = 4, Alpha2Code = "EG", Alpha3Code = "EGY",
                    UnCode = "818"
                },
                new Country()
                {
                    Id = 434,
                    Name = "Libya", RegionId = 4, Alpha2Code = "LY", Alpha3Code = "LBY",
                    UnCode = "434"
                },
                new Country()
                {
                    Id = 504,
                    Name = "Morocco", RegionId = 4, Alpha2Code = "MA", Alpha3Code = "MAR",
                    UnCode = "504"
                },
                new Country()
                {
                    Id = 736,
                    Name = "Sudan", RegionId = 4, Alpha2Code = "SD", Alpha3Code = "SDN",
                    UnCode = "736"
                },
                new Country()
                {
                    Id = 788,
                    Name = "Tunisia", RegionId = 4, Alpha2Code = "TN", Alpha3Code = "TUN",
                    UnCode = "788"
                },
                new Country()
                {
                    Id = 732,
                    Name = "Western Sahara", RegionId = 4, Alpha2Code = "EH",
                    Alpha3Code = "ESH", UnCode = "732"
                },
                new Country()
                {
                    Id = 024,
                    Name = "Angola", RegionId = 5, Alpha2Code = "AO", Alpha3Code = "AGO",
                    UnCode = "024"
                },
                new Country()
                {
                    Id = 072,
                    Name = "Botswana", RegionId = 5, Alpha2Code = "BW", Alpha3Code = "BWA",
                    UnCode = "072"
                },
                new Country()
                {
                    Id = 426,
                    Name = "Lesotho", RegionId = 5, Alpha2Code = "LS", Alpha3Code = "LSO",
                    UnCode = "426"
                },
                new Country()
                {
                    Id = 454,
                    Name = "Malawi", RegionId = 5, Alpha2Code = "MW", Alpha3Code = "MWI",
                    UnCode = "454"
                },
                new Country()
                {
                    Id = 508,
                    Name = "Mozambique", RegionId = 5, Alpha2Code = "MZ", Alpha3Code = "MOZ",
                    UnCode = "508"
                },
                new Country()
                {
                    Id = 710,
                    Name = "South Africa", RegionId = 5, Alpha2Code = "ZA", Alpha3Code = "ZAF",
                    UnCode = "710"
                },
                new Country()
                {
                    Id = 516,
                    Name = "Namibia", RegionId = 5, Alpha2Code = "NA", Alpha3Code = "NAM",
                    UnCode = "516"
                },
                new Country()
                {
                    Id = 748,
                    Name = "Swaziland", RegionId = 5, Alpha2Code = "SZ", Alpha3Code = "SWZ",
                    UnCode = "748"
                },
                new Country()
                {
                    Id = 894,
                    Name = "Zambia", RegionId = 5, Alpha2Code = "ZM", Alpha3Code = "ZMB",
                    UnCode = "894"
                },
                new Country()
                {
                    Id = 716,
                    Name = "Zimbabwe", RegionId = 5, Alpha2Code = "ZW", Alpha3Code = "ZWE",
                    UnCode = "716"
                },
                new Country()
                {
                    Id = 204,
                    Name = "Benin", RegionId = 6, Alpha2Code = "BJ", Alpha3Code = "BEN",
                    UnCode = "204"
                },
                new Country()
                {
                    Id = 120,
                    Name = "Cameroon", RegionId = 6, Alpha2Code = "CM", Alpha3Code = "CMR",
                    UnCode = "120"
                },
                new Country()
                {
                    Id = 132,
                    Name = "Cape Verde", RegionId = 6, Alpha2Code = "CV", Alpha3Code = "CPV",
                    UnCode = "132"
                },
                new Country()
                {
                    Id = 226,
                    Name = "Equatorial Guinea", RegionId = 6, Alpha2Code = "GQ",
                    Alpha3Code = "GNQ", UnCode = "226"
                },
                new Country()
                {
                    Id = 270,
                    Name = "Gambia, The", RegionId = 6, Alpha2Code = "GM", Alpha3Code = "GMB",
                    UnCode = "270"
                },
                new Country()
                {
                    Id = 266,
                    Name = "Gabon", RegionId = 6, Alpha2Code = "GA", Alpha3Code = "GAB",
                    UnCode = "266"
                },
                new Country()
                {
                    Id = 288,
                    Name = "Ghana", RegionId = 6, Alpha2Code = "GH", Alpha3Code = "GHA",
                    UnCode = "288"
                },
                new Country()
                {
                    Id = 324,
                    Name = "Guinea", RegionId = 6, Alpha2Code = "GN", Alpha3Code = "GIN",
                    UnCode = "324"
                },
                new Country()
                {
                    Id = 384,
                    Name = "Cote d'Ivoire", RegionId = 6, Alpha2Code = "CI", Alpha3Code = "CIV",
                    UnCode = "384"
                },
                new Country()
                {
                    Id = 430,
                    Name = "Liberia", RegionId = 6, Alpha2Code = "LR", Alpha3Code = "LBR",
                    UnCode = "430"
                },
                new Country()
                {
                    Id = 466,
                    Name = "Mali", RegionId = 6, Alpha2Code = "ML", Alpha3Code = "MLI",
                    UnCode = "466"
                },
                new Country()
                {
                    Id = 478,
                    Name = "Mauritania", RegionId = 6, Alpha2Code = "MR", Alpha3Code = "MRT",
                    UnCode = "478"
                },
                new Country()
                {
                    Id = 562,
                    Name = "Niger", RegionId = 6, Alpha2Code = "NE", Alpha3Code = "NER",
                    UnCode = "562"
                },
                new Country()
                {
                    Id = 566,
                    Name = "Nigeria", RegionId = 6, Alpha2Code = "NG", Alpha3Code = "NGA",
                    UnCode = "566"
                },
                new Country()
                {
                    Id = 624,
                    Name = "Guinea-Bissau", RegionId = 6, Alpha2Code = "GW", Alpha3Code = "GNB",
                    UnCode = "624"
                },
                new Country()
                {
                    Id = 686,
                    Name = "Senegal", RegionId = 6, Alpha2Code = "SN", Alpha3Code = "SEN",
                    UnCode = "686"
                },
                new Country()
                {
                    Id = 694,
                    Name = "Sierra Leone", RegionId = 6, Alpha2Code = "SL", Alpha3Code = "SLE",
                    UnCode = "694"
                },
                new Country()
                {
                    Id = 768,
                    Name = "Togo", RegionId = 6, Alpha2Code = "TG", Alpha3Code = "TGO",
                    UnCode = "768"
                },
                new Country()
                {
                    Id = 678,
                    Name = "Sao Tome and Principe", RegionId = 6, Alpha2Code = "ST",
                    Alpha3Code = "STP", UnCode = "678"
                },
                new Country()
                {
                    Id = 854,
                    Name = "Burkina Faso", RegionId = 6, Alpha2Code = "BF", Alpha3Code = "BFA",
                    UnCode = "854"
                },
                new Country()
                {
                    Id = 084,
                    Name = "Belize", RegionId = 7, Alpha2Code = "BZ", Alpha3Code = "BLZ",
                    UnCode = "084"
                },
                new Country()
                {
                    Id = 188,
                    Name = "Costa Rica", RegionId = 7, Alpha2Code = "CR", Alpha3Code = "CRI",
                    UnCode = "188"
                },
                new Country()
                {
                    Id = 222,
                    Name = "El Salvador", RegionId = 7, Alpha2Code = "SV", Alpha3Code = "SLV",
                    UnCode = "222"
                },
                new Country()
                {
                    Id = 320,
                    Name = "Guatemala", RegionId = 7, Alpha2Code = "GT", Alpha3Code = "GTM",
                    UnCode = "320"
                },
                new Country()
                {
                    Id = 340,
                    Name = "Honduras", RegionId = 7, Alpha2Code = "HN", Alpha3Code = "HND",
                    UnCode = "340"
                },
                new Country()
                {
                    Id = 484,
                    Name = "Mexico", RegionId = 7, Alpha2Code = "MX", Alpha3Code = "MEX",
                    UnCode = "484"
                },
                new Country()
                {
                    Id = 558,
                    Name = "Nicaragua", RegionId = 7, Alpha2Code = "NI", Alpha3Code = "NIC",
                    UnCode = "558"
                },
                new Country()
                {
                    Id = 591,
                    Name = "Panama", RegionId = 7, Alpha2Code = "PA", Alpha3Code = "PAN",
                    UnCode = "591"
                },
                new Country()
                {
                    Id = 124,
                    Name = "Canada", RegionId = 8, Alpha2Code = "CA", Alpha3Code = "CAN",
                    UnCode = "124"
                },
                new Country()
                {
                    Id = 304,
                    Name = "Greenland", RegionId = 8, Alpha2Code = "GL", Alpha3Code = "GRL",
                    UnCode = "304"
                },
                new Country()
                {
                    Id = 666,
                    Name = "Saint Pierre and Miquelon", RegionId = 8, Alpha2Code = "PM",
                    Alpha3Code = "SPM", UnCode = "666"
                },
                new Country()
                {
                    Id = 840,
                    Name = "United States of America", RegionId = 8, Alpha2Code = "US",
                    Alpha3Code = "USA", UnCode = "840"
                },
                new Country()
                {
                    Id = 032,
                    Name = "Argentina", RegionId = 9, Alpha2Code = "AR", Alpha3Code = "ARG",
                    UnCode = "032"
                },
                new Country()
                {
                    Id = 068,
                    Name = "Bolivia", RegionId = 9, Alpha2Code = "BO", Alpha3Code = "BOL",
                    UnCode = "068"
                },
                new Country()
                {
                    Id = 076,
                    Name = "Brazil", RegionId = 9, Alpha2Code = "BR", Alpha3Code = "BRA",
                    UnCode = "076"
                },
                new Country()
                {
                    Id = 152,
                    Name = "Chile", RegionId = 9, Alpha2Code = "CL", Alpha3Code = "CHL",
                    UnCode = "152"
                },
                new Country()
                {
                    Id = 170,
                    Name = "Colombia", RegionId = 9, Alpha2Code = "CO", Alpha3Code = "COL",
                    UnCode = "170"
                },
                new Country()
                {
                    Id = 218,
                    Name = "Ecuador", RegionId = 9, Alpha2Code = "EC", Alpha3Code = "ECU",
                    UnCode = "218"
                },
                new Country()
                {
                    Id = 254,
                    Name = "French Guiana", RegionId = 9, Alpha2Code = "GF", Alpha3Code = "GUF",
                    UnCode = "254"
                },
                new Country()
                {
                    Id = 238,
                    Name = "Falkland Islands (Islas Malvinas)", RegionId = 9,
                    Alpha2Code = "FK", Alpha3Code = "FLK", UnCode = "238"
                },
                new Country()
                {
                    Id = 328,
                    Name = "Guyana", RegionId = 9, Alpha2Code = "GY", Alpha3Code = "GUY",
                    UnCode = "328"
                },
                new Country()
                {
                    Id = 740,
                    Name = "Suriname", RegionId = 9, Alpha2Code = "SR", Alpha3Code = "SUR",
                    UnCode = "740"
                },
                new Country()
                {
                    Id = 600,
                    Name = "Paraguay", RegionId = 9, Alpha2Code = "PY", Alpha3Code = "PRY",
                    UnCode = "600"
                },
                new Country()
                {
                    Id = 604,
                    Name = "Peru", RegionId = 9, Alpha2Code = "PE", Alpha3Code = "PER",
                    UnCode = "604"
                },
                new Country()
                {
                    Id = 858,
                    Name = "Uruguay", RegionId = 9, Alpha2Code = "UY", Alpha3Code = "URY",
                    UnCode = "858"
                },
                new Country()
                {
                    Id = 862,
                    Name = "Venezuela (Bolivarian Republic)", RegionId = 9, Alpha2Code = "VE",
                    Alpha3Code = "VEN", UnCode = "862"
                },
                new Country()
                {
                    Id = 533,
                    Name = "Aruba", RegionId = 10, Alpha2Code = "AW", Alpha3Code = "ABW",
                    UnCode = "533"
                },
                new Country()
                {
                    Id = 028,
                    Name = "Antigua and Barbuda", RegionId = 10, Alpha2Code = "AG",
                    Alpha3Code = "ATG", UnCode = "028"
                },
                new Country()
                {
                    Id = 660,
                    Name = "Anguilla", RegionId = 10, Alpha2Code = "AI", Alpha3Code = "AIA",
                    UnCode = "660"
                },
                new Country()
                {
                    Id = 052,
                    Name = "Barbados", RegionId = 10, Alpha2Code = "BB", Alpha3Code = "BRB",
                    UnCode = "052"
                },
                new Country()
                {
                    Id = 060,
                    Name = "Bermuda", RegionId = 10, Alpha2Code = "BM", Alpha3Code = "BMU",
                    UnCode = "060"
                },
                new Country()
                {
                    Id = 044,
                    Name = "Bahamas, The", RegionId = 10, Alpha2Code = "BS", Alpha3Code = "BHS",
                    UnCode = "044"
                },
                new Country()
                {
                    Id = 136,
                    Name = "Cayman Islands", RegionId = 10, Alpha2Code = "KY",
                    Alpha3Code = "CYM", UnCode = "136"
                },
                new Country()
                {
                    Id = 192,
                    Name = "Cuba", RegionId = 10, Alpha2Code = "CU", Alpha3Code = "CUB",
                    UnCode = "192"
                },
                new Country()
                {
                    Id = 212,
                    Name = "Dominica", RegionId = 10, Alpha2Code = "DM", Alpha3Code = "DMA",
                    UnCode = "212"
                },
                new Country()
                {
                    Id = 214,
                    Name = "Dominican Republic", RegionId = 10, Alpha2Code = "DO",
                    Alpha3Code = "DOM", UnCode = "214"
                },
                new Country()
                {
                    Id = 308,
                    Name = "Grenada", RegionId = 10, Alpha2Code = "GD", Alpha3Code = "GRD",
                    UnCode = "308"
                },
                new Country()
                {
                    Id = 312,
                    Name = "Guadeloupe", RegionId = 10, Alpha2Code = "GP", Alpha3Code = "GLP",
                    UnCode = "312"
                },
                new Country()
                {
                    Id = 332,
                    Name = "Haiti", RegionId = 10, Alpha2Code = "HT", Alpha3Code = "HTI",
                    UnCode = "332"
                },
                new Country()
                {
                    Id = 388,
                    Name = "Jamaica", RegionId = 10, Alpha2Code = "JM", Alpha3Code = "JAM",
                    UnCode = "388"
                },
                new Country()
                {
                    Id = 474,
                    Name = "Martinique", RegionId = 10, Alpha2Code = "MQ", Alpha3Code = "MTQ",
                    UnCode = "474"
                },
                new Country()
                {
                    Id = 500,
                    Name = "Montserrat", RegionId = 10, Alpha2Code = "MS", Alpha3Code = "MSR",
                    UnCode = "500"
                },
                new Country()
                {
                    Id = 663,
                    Name = "Saint-Martin (French part)", RegionId = 10, Alpha2Code = "MF",
                    Alpha3Code = "MAF", UnCode = "663"
                },
                new Country()
                {
                    Id = 659,
                    Name = "Saint Kitts and Nevis", RegionId = 10, Alpha2Code = "KN",
                    Alpha3Code = "KNA", UnCode = "659"
                },
                new Country()
                {
                    Id = 662,
                    Name = "Saint Lucia", RegionId = 10, Alpha2Code = "LC", Alpha3Code = "LCA",
                    UnCode = "662"
                },
                new Country()
                {
                    Id = 780,
                    Name = "Trinidad and Tobago", RegionId = 10, Alpha2Code = "TT",
                    Alpha3Code = "TTO", UnCode = "780"
                },
                new Country()
                {
                    Id = 796,
                    Name = "Turks and Caicos Islands", RegionId = 10, Alpha2Code = "TC",
                    Alpha3Code = "TCA", UnCode = "796"
                },
                new Country()
                {
                    Id = 670,
                    Name = "Saint Vincent and the Grenadines", RegionId = 10,
                    Alpha2Code = "VC", Alpha3Code = "VCT", UnCode = "670"
                },
                new Country()
                {
                    Id = 092,
                    Name = "British Virgin Islands", RegionId = 10, Alpha2Code = "VG",
                    Alpha3Code = "VGB", UnCode = "092"
                },
                new Country()
                {
                    Id = 654,
                    Name = "Saint Helena", RegionId = 11, Alpha2Code = "SH", Alpha3Code = "SHN",
                    UnCode = "654"
                },
                new Country()
                {
                    Id = 239,
                    Name = "South Georgia and the South Sandwich Islands", RegionId = 11,
                    Alpha2Code = "GS", Alpha3Code = "SGS", UnCode = "239"
                },
                new Country()
                {
                    Id = 417,
                    Name = "Kyrgyzstan", RegionId = 12, Alpha2Code = "KG", Alpha3Code = "KGZ",
                    UnCode = "417"
                },
                new Country()
                {
                    Id = 398,
                    Name = "Kazakhstan", RegionId = 12, Alpha2Code = "KZ", Alpha3Code = "KAZ",
                    UnCode = "398"
                },
                new Country()
                {
                    Id = 762,
                    Name = "Tajikistan", RegionId = 12, Alpha2Code = "TJ", Alpha3Code = "TJK",
                    UnCode = "762"
                },
                new Country()
                {
                    Id = 795,
                    Name = "Turkmenistan", RegionId = 12, Alpha2Code = "TM", Alpha3Code = "TKM",
                    UnCode = "795"
                },
                new Country()
                {
                    Id = 860,
                    Name = "Uzbekistan", RegionId = 12, Alpha2Code = "UZ", Alpha3Code = "UZB",
                    UnCode = "860"
                },
                new Country()
                {
                    Id = 156,
                    Name = "China", RegionId = 13, Alpha2Code = "CN", Alpha3Code = "CHN",
                    UnCode = "156"
                },
                new Country()
                {
                    Id = 344,
                    Name = "Hong Kong, SAR China", RegionId = 13, Alpha2Code = "HK",
                    Alpha3Code = "HKG", UnCode = "344"
                },
                new Country()
                {
                    Id = 392,
                    Name = "Japan", RegionId = 13, Alpha2Code = "JP", Alpha3Code = "JPN",
                    UnCode = "392"
                },
                new Country()
                {
                    Id = 408,
                    Name = "Korea, North", RegionId = 13, Alpha2Code = "KP", Alpha3Code = "PRK",
                    UnCode = "408"
                },
                new Country()
                {
                    Id = 410,
                    Name = "Korea, South", RegionId = 13, Alpha2Code = "KR", Alpha3Code = "KOR",
                    UnCode = "410"
                },
                new Country()
                {
                    Id = 446,
                    Name = "Macao, SAR China", RegionId = 13, Alpha2Code = "MO",
                    Alpha3Code = "MAC", UnCode = "446"
                },
                new Country()
                {
                    Id = 158,
                    Name = "Taiwan, Republic of China", RegionId = 13, Alpha2Code = "TW",
                    Alpha3Code = "TWN", UnCode = "158"
                },
                new Country()
                {
                    Id = 496,
                    Name = "Mongolia", RegionId = 14, Alpha2Code = "MN", Alpha3Code = "MNG",
                    UnCode = "496"
                },
                new Country()
                {
                    Id = 643,
                    Name = "Russian Federation", RegionId = 14, Alpha2Code = "RU",
                    Alpha3Code = "RUS", UnCode = "643"
                },
                new Country()
                {
                    Id = 004,
                    Name = "Afghanistan", RegionId = 15, Alpha2Code = "AF", Alpha3Code = "AFG",
                    UnCode = "004"
                },
                new Country()
                {
                    Id = 050,
                    Name = "Bangladesh", RegionId = 15, Alpha2Code = "BD", Alpha3Code = "BGD",
                    UnCode = "050"
                },
                new Country()
                {
                    Id = 064,
                    Name = "Bhutan", RegionId = 15, Alpha2Code = "BT", Alpha3Code = "BTN",
                    UnCode = "064"
                },
                new Country()
                {
                    Id = 144,
                    Name = "Sri Lanka", RegionId = 15, Alpha2Code = "LK", Alpha3Code = "LKA",
                    UnCode = "144"
                },
                new Country()
                {
                    Id = 356,
                    Name = "India", RegionId = 15, Alpha2Code = "IN", Alpha3Code = "IND",
                    UnCode = "356"
                },
                new Country()
                {
                    Id = 086,
                    Name = "British Indian Ocean Territory", RegionId = 15,
                    Alpha2Code = "IO", Alpha3Code = "IOT", UnCode = "086"
                },
                new Country()
                {
                    Id = 462,
                    Name = "Maldives", RegionId = 15, Alpha2Code = "MV", Alpha3Code = "MDV",
                    UnCode = "462"
                },
                new Country()
                {
                    Id = 524,
                    Name = "Nepal", RegionId = 15, Alpha2Code = "NP", Alpha3Code = "NPL",
                    UnCode = "524"
                },
                new Country()
                {
                    Id = 586,
                    Name = "Pakistan", RegionId = 15, Alpha2Code = "PK", Alpha3Code = "PAK",
                    UnCode = "586"
                },
                new Country()
                {
                    Id = 104,
                    Name = "Myanmar", RegionId = 15, Alpha2Code = "MM", Alpha3Code = "MMR",
                    UnCode = "104"
                },
                new Country()
                {
                    Id = 096,
                    Name = "Brunei Darussalam", RegionId = 15, Alpha2Code = "BN",
                    Alpha3Code = "BRN", UnCode = "096"
                },
                new Country()
                {
                    Id = 116,
                    Name = "Cambodia", RegionId = 15, Alpha2Code = "KH", Alpha3Code = "KHM",
                    UnCode = "116"
                },
                new Country()
                {
                    Id = 166,
                    Name = "Cocos (Keeling) Islands", RegionId = 15, Alpha2Code = "CC",
                    Alpha3Code = "CCK", UnCode = "166"
                },
                new Country()
                {
                    Id = 360,
                    Name = "Indonesia", RegionId = 15, Alpha2Code = "ID", Alpha3Code = "IDN",
                    UnCode = "360"
                },
                new Country()
                {
                    Id = 162,
                    Name = "Christmas Island", RegionId = 15, Alpha2Code = "CX",
                    Alpha3Code = "CXR", UnCode = "162"
                },
                new Country()
                {
                    Id = 418,
                    Name = "Lao PDR", RegionId = 15, Alpha2Code = "LA", Alpha3Code = "LAO",
                    UnCode = "418"
                },
                new Country()
                {
                    Id = 458,
                    Name = "Malaysia", RegionId = 15, Alpha2Code = "MY", Alpha3Code = "MYS",
                    UnCode = "458"
                },
                new Country()
                {
                    Id = 608,
                    Name = "Philippines", RegionId = 15, Alpha2Code = "PH", Alpha3Code = "PHL",
                    UnCode = "608"
                },
                new Country()
                {
                    Id = 702,
                    Name = "Singapore", RegionId = 15, Alpha2Code = "SG", Alpha3Code = "SGP",
                    UnCode = "702"
                },
                new Country()
                {
                    Id = 764,
                    Name = "Thailand", RegionId = 15, Alpha2Code = "TH", Alpha3Code = "THA",
                    UnCode = "764"
                },
                new Country()
                {
                    Id = 626,
                    Name = "Timor-Leste", RegionId = 15, Alpha2Code = "TL", Alpha3Code = "TLS",
                    UnCode = "626"
                },
                new Country()
                {
                    Id = 704,
                    Name = "Vietnam", RegionId = 15, Alpha2Code = "VN", Alpha3Code = "VNM",
                    UnCode = "704"
                },
                new Country()
                {
                    Id = 784,
                    Name = "United Arab Emirates", RegionId = 16, Alpha2Code = "AE",
                    Alpha3Code = "ARE", UnCode = "784"
                },
                new Country()
                {
                    Id = 031,
                    Name = "Azerbaijan", RegionId = 16, Alpha2Code = "AZ", Alpha3Code = "AZE",
                    UnCode = "031"
                },
                new Country()
                {
                    Id = 051,
                    Name = "Armenia", RegionId = 16, Alpha2Code = "AM", Alpha3Code = "ARM",
                    UnCode = "051"
                },
                new Country()
                {
                    Id = 048,
                    Name = "Bahrain", RegionId = 16, Alpha2Code = "BH", Alpha3Code = "BHR",
                    UnCode = "048"
                },
                new Country()
                {
                    Id = 196,
                    Name = "Cyprus", RegionId = 16, Alpha2Code = "CY", Alpha3Code = "CYP",
                    UnCode = "196"
                },
                new Country()
                {
                    Id = 268,
                    Name = "Georgia", RegionId = 16, Alpha2Code = "GE", Alpha3Code = "GEO",
                    UnCode = "268"
                },
                new Country()
                {
                    Id = 376,
                    Name = "Israel", RegionId = 16, Alpha2Code = "IL", Alpha3Code = "ISR",
                    UnCode = "376"
                },
                new Country()
                {
                    Id = 364,
                    Name = "Iran, Islamic Republic of", RegionId = 16, Alpha2Code = "IR",
                    Alpha3Code = "IRN", UnCode = "364"
                },
                new Country()
                {
                    Id = 368,
                    Name = "Iraq", RegionId = 16, Alpha2Code = "IQ", Alpha3Code = "IRQ",
                    UnCode = "368"
                },
                new Country()
                {
                    Id = 400,
                    Name = "Jordan", RegionId = 16, Alpha2Code = "JO", Alpha3Code = "JOR",
                    UnCode = "400"
                },
                new Country()
                {
                    Id = 414,
                    Name = "Kuwait", RegionId = 16, Alpha2Code = "KW", Alpha3Code = "KWT",
                    UnCode = "414"
                },
                new Country()
                {
                    Id = 422,
                    Name = "Lebanon", RegionId = 16, Alpha2Code = "LB", Alpha3Code = "LBN",
                    UnCode = "422"
                },
                new Country()
                {
                    Id = 512,
                    Name = "Oman", RegionId = 16, Alpha2Code = "OM", Alpha3Code = "OMN",
                    UnCode = "512"
                },
                new Country()
                {
                    Id = 634,
                    Name = "Qatar", RegionId = 16, Alpha2Code = "QA", Alpha3Code = "QAT",
                    UnCode = "634"
                },
                new Country()
                {
                    Id = 682,
                    Name = "Saudi Arabia", RegionId = 16, Alpha2Code = "SA", Alpha3Code = "SAU",
                    UnCode = "682"
                },
                new Country()
                {
                    Id = 760,
                    Name = "Syrian Arab Republic (Syria)", RegionId = 16, Alpha2Code = "SY",
                    Alpha3Code = "SYR", UnCode = "760"
                },
                new Country()
                {
                    Id = 792,
                    Name = "Turkey", RegionId = 16, Alpha2Code = "TR", Alpha3Code = "TUR",
                    UnCode = "792"
                },
                new Country()
                {
                    Id = 887,
                    Name = "Yemen", RegionId = 16, Alpha2Code = "YE", Alpha3Code = "YEM",
                    UnCode = "887"
                },
                new Country()
                {
                    Id = 040,
                    Name = "Austria", RegionId = 17, Alpha2Code = "AT", Alpha3Code = "AUT",
                    UnCode = "040"
                },
                new Country()
                {
                    Id = 203,
                    Name = "Czech Republic", RegionId = 17, Alpha2Code = "CZ",
                    Alpha3Code = "CZE", UnCode = "203"
                },
                new Country()
                {
                    Id = 348,
                    Name = "Hungary", RegionId = 17, Alpha2Code = "HU", Alpha3Code = "HUN",
                    UnCode = "348"
                },
                new Country()
                {
                    Id = 703,
                    Name = "Slovakia", RegionId = 17, Alpha2Code = "SK", Alpha3Code = "SVK",
                    UnCode = "703"
                },
                new Country()
                {
                    Id = 438,
                    Name = "Liechtenstein", RegionId = 17, Alpha2Code = "LI",
                    Alpha3Code = "LIE", UnCode = "438"
                },
                new Country()
                {
                    Id = 756,
                    Name = "Switzerland", RegionId = 17, Alpha2Code = "CH", Alpha3Code = "CHE",
                    UnCode = "756"
                },
                new Country()
                {
                    Id = 112,
                    Name = "Belarus", RegionId = 18, Alpha2Code = "BY", Alpha3Code = "BLR",
                    UnCode = "112"
                },
                new Country()
                {
                    Id = 233,
                    Name = "Estonia", RegionId = 18, Alpha2Code = "EE", Alpha3Code = "EST",
                    UnCode = "233"
                },
                new Country()
                {
                    Id = 428,
                    Name = "Latvia", RegionId = 18, Alpha2Code = "LV", Alpha3Code = "LVA",
                    UnCode = "428"
                },
                new Country()
                {
                    Id = 440,
                    Name = "Lithuania", RegionId = 18, Alpha2Code = "LT", Alpha3Code = "LTU",
                    UnCode = "440"
                },
                new Country()
                {
                    Id = 498,
                    Name = "Moldova, Republic of", RegionId = 18, Alpha2Code = "MD",
                    Alpha3Code = "MDA", UnCode = "498"
                },
                new Country()
                {
                    Id = 616,
                    Name = "Poland", RegionId = 18, Alpha2Code = "PL", Alpha3Code = "POL",
                    UnCode = "616"
                },
                new Country()
                {
                    Id = 804,
                    Name = "Ukraine", RegionId = 18, Alpha2Code = "UA", Alpha3Code = "UKR",
                    UnCode = "804"
                },
                new Country()
                {
                    Id = 248,
                    Name = "Åland Islands", RegionId = 19, Alpha2Code = "AX",
                    Alpha3Code = "ALA", UnCode = "248"
                },
                new Country()
                {
                    Id = 208,
                    Name = "Denmark", RegionId = 19, Alpha2Code = "DK", Alpha3Code = "DNK",
                    UnCode = "208"
                },
                new Country()
                {
                    Id = 246,
                    Name = "Finland", RegionId = 19, Alpha2Code = "FI", Alpha3Code = "FIN",
                    UnCode = "246"
                },
                new Country()
                {
                    Id = 234,
                    Name = "Faroe Islands", RegionId = 19, Alpha2Code = "FO",
                    Alpha3Code = "FRO", UnCode = "234"
                },
                new Country()
                {
                    Id = 352,
                    Name = "Iceland", RegionId = 19, Alpha2Code = "IS", Alpha3Code = "ISL",
                    UnCode = "352"
                },
                new Country()
                {
                    Id = 744,
                    Name = "Svalbard and Jan Mayen Islands", RegionId = 19, Alpha2Code = "SJ",
                    Alpha3Code = "SJM", UnCode = "744"
                },
                new Country()
                {
                    Id = 578,
                    Name = "Norway", RegionId = 19, Alpha2Code = "NO", Alpha3Code = "NOR",
                    UnCode = "578"
                },
                new Country()
                {
                    Id = 752,
                    Name = "Sweden", RegionId = 19, Alpha2Code = "SE", Alpha3Code = "SWE",
                    UnCode = "752"
                },
                new Country()
                {
                    Id = 008,
                    Name = "Albania", RegionId = 20, Alpha2Code = "AL", Alpha3Code = "ALB",
                    UnCode = "008"
                },
                new Country()
                {
                    Id = 070,
                    Name = "Bosnia and Herzegovina", RegionId = 20, Alpha2Code = "BA",
                    Alpha3Code = "BIH", UnCode = "070"
                },
                new Country()
                {
                    Id = 100,
                    Name = "Bulgaria", RegionId = 20, Alpha2Code = "BG", Alpha3Code = "BGR",
                    UnCode = "100"
                },
                new Country()
                {
                    Id = 300,
                    Name = "Greece", RegionId = 20, Alpha2Code = "GR", Alpha3Code = "GRC",
                    UnCode = "300"
                },
                new Country()
                {
                    Id = 191,
                    Name = "Croatia", RegionId = 20, Alpha2Code = "HR", Alpha3Code = "HRV",
                    UnCode = "191"
                },
                new Country()
                {
                    Id = 383,
                    Name = "Kosovo", RegionId = 20, Alpha2Code = "XK", Alpha3Code = "XKX",
                    UnCode = "383"
                },
                new Country()
                {
                    Id = 499,
                    Name = "Montenegro", RegionId = 20, Alpha2Code = "ME", Alpha3Code = "MNE",
                    UnCode = "499"
                },
                new Country()
                {
                    Id = 807,
                    Name = "Macedonia, Republic of", RegionId = 20,
                    Alpha2Code = "MK", Alpha3Code = "MKD", UnCode = "807"
                },
                new Country()
                {
                    Id = 688,
                    Name = "Serbia", RegionId = 20, Alpha2Code = "RS", Alpha3Code = "SRB",
                    UnCode = "688"
                },
                new Country()
                {
                    Id = 642,
                    Name = "Romania", RegionId = 20, Alpha2Code = "RO", Alpha3Code = "ROU",
                    UnCode = "642"
                },
                new Country()
                {
                    Id = 705,
                    Name = "Slovenia", RegionId = 20, Alpha2Code = "SI", Alpha3Code = "SVN",
                    UnCode = "705"
                },
                new Country()
                {
                    Id = 020,
                    Name = "Andorra", RegionId = 21, Alpha2Code = "AD", Alpha3Code = "AND",
                    UnCode = "020"
                },
                new Country()
                {
                    Id = 292,
                    Name = "Gibraltar", RegionId = 21, Alpha2Code = "GI", Alpha3Code = "GIB",
                    UnCode = "292"
                },
                new Country()
                {
                    Id = 620,
                    Name = "Portugal", RegionId = 21, Alpha2Code = "PT", Alpha3Code = "PRT",
                    UnCode = "620"
                },
                new Country()
                {
                    Id = 724,
                    Name = "Spain", RegionId = 21, Alpha2Code = "ES", Alpha3Code = "ESP",
                    UnCode = "724"
                },
                new Country()
                {
                    Id = 380,
                    Name = "Italy", RegionId = 22, Alpha2Code = "IT", Alpha3Code = "ITA",
                    UnCode = "380"
                },
                new Country()
                {
                    Id = 470,
                    Name = "Malta", RegionId = 22, Alpha2Code = "MT", Alpha3Code = "MLT",
                    UnCode = "470"
                },
                new Country()
                {
                    Id = 674,
                    Name = "San Marino", RegionId = 22, Alpha2Code = "SM", Alpha3Code = "SMR",
                    UnCode = "674"
                },
                new Country()
                {
                    Id = 056,
                    Name = "Belgium", RegionId = 23, Alpha2Code = "BE", Alpha3Code = "BEL",
                    UnCode = "056"
                },
                new Country()
                {
                    Id = 372,
                    Name = "Ireland", RegionId = 23, Alpha2Code = "IE", Alpha3Code = "IRL",
                    UnCode = "372"
                },
                new Country()
                {
                    Id = 250,
                    Name = "France", RegionId = 23, Alpha2Code = "FR", Alpha3Code = "FRA",
                    UnCode = "250"
                },
                new Country()
                {
                    Id = 826,
                    Name = "United Kingdom", RegionId = 23, Alpha2Code = "GB",
                    Alpha3Code = "GBR", UnCode = "826"
                },
                new Country()
                {
                    Id = 276,
                    Name = "Germany", RegionId = 23, Alpha2Code = "DE", Alpha3Code = "DEU",
                    UnCode = "276"
                },
                new Country()
                {
                    Id = 833,
                    Name = "Isle of Man", RegionId = 23, Alpha2Code = "IM", Alpha3Code = "IMN",
                    UnCode = "833"
                },
                new Country()
                {
                    Id = 832,
                    Name = "Jersey", RegionId = 23, Alpha2Code = "JE", Alpha3Code = "JEY",
                    UnCode = "832"
                },
                new Country()
                {
                    Id = 442,
                    Name = "Luxembourg", RegionId = 23, Alpha2Code = "LU", Alpha3Code = "LUX",
                    UnCode = "442"
                },
                new Country()
                {
                    Id = 492,
                    Name = "Monaco", RegionId = 23, Alpha2Code = "MC", Alpha3Code = "MCO",
                    UnCode = "492"
                },
                new Country()
                {
                    Id = 528,
                    Name = "Netherlands", RegionId = 23, Alpha2Code = "NL", Alpha3Code = "NLD",
                    UnCode = "528"
                },
                new Country()
                {
                    Id = 036,
                    Name = "Australia", RegionId = 24, Alpha2Code = "AU", Alpha3Code = "AUS",
                    UnCode = "036"
                },
                new Country()
                {
                    Id = 090,
                    Name = "Solomon Islands", RegionId = 24, Alpha2Code = "SB",
                    Alpha3Code = "SLB", UnCode = "090"
                },
                new Country()
                {
                    Id = 184,
                    Name = "Cook Islands", RegionId = 24, Alpha2Code = "CK", Alpha3Code = "COK",
                    UnCode = "184"
                },
                new Country()
                {
                    Id = 242,
                    Name = "Fiji", RegionId = 24, Alpha2Code = "FJ", Alpha3Code = "FJI",
                    UnCode = "242"
                },
                new Country()
                {
                    Id = 583,
                    Name = "Micronesia, Federated States of", RegionId = 24,
                    Alpha2Code = "FM", Alpha3Code = "FSM", UnCode = "583"
                },
                new Country()
                {
                    Id = 258,
                    Name = "French Polynesia", RegionId = 24, Alpha2Code = "PF",
                    Alpha3Code = "PYF", UnCode = "258"
                },
                new Country()
                {
                    Id = 296,
                    Name = "Kiribati", RegionId = 24, Alpha2Code = "KI", Alpha3Code = "KIR",
                    UnCode = "296"
                },
                new Country()
                {
                    Id = 540,
                    Name = "New Caledonia", RegionId = 24, Alpha2Code = "NC",
                    Alpha3Code = "NCL", UnCode = "540"
                },
                new Country()
                {
                    Id = 570,
                    Name = "Niue", RegionId = 24, Alpha2Code = "NU", Alpha3Code = "NIU",
                    UnCode = "570"
                },
                new Country()
                {
                    Id = 574,
                    Name = "Norfolk Island", RegionId = 24, Alpha2Code = "NF",
                    Alpha3Code = "NFK", UnCode = "574"
                },
                new Country()
                {
                    Id = 548,
                    Name = "Vanuatu", RegionId = 24, Alpha2Code = "VU", Alpha3Code = "VUT",
                    UnCode = "548"
                },
                new Country()
                {
                    Id = 520,
                    Name = "Nauru", RegionId = 24, Alpha2Code = "NR", Alpha3Code = "NRU",
                    UnCode = "520"
                },
                new Country()
                {
                    Id = 554,
                    Name = "New Zealand", RegionId = 24, Alpha2Code = "NZ", Alpha3Code = "NZL",
                    UnCode = "554"
                },
                new Country()
                {
                    Id = 612,
                    Name = "Pitcairn Islands", RegionId = 24, Alpha2Code = "PN",
                    Alpha3Code = "PCN", UnCode = "612"
                },
                new Country()
                {
                    Id = 598,
                    Name = "Papua New Guinea", RegionId = 24, Alpha2Code = "PG",
                    Alpha3Code = "PNG", UnCode = "598"
                },
                new Country()
                {
                    Id = 585,
                    Name = "Palau", RegionId = 24, Alpha2Code = "PW", Alpha3Code = "PLW",
                    UnCode = "585"
                },
                new Country()
                {
                    Id = 584,
                    Name = "Marshall Islands", RegionId = 24, Alpha2Code = "MH",
                    Alpha3Code = "MHL", UnCode = "584"
                },
                new Country()
                {
                    Id = 772,
                    Name = "Tokelau", RegionId = 24, Alpha2Code = "TK", Alpha3Code = "TKL",
                    UnCode = "772"
                },
                new Country()
                {
                    Id = 776,
                    Name = "Tonga", RegionId = 24, Alpha2Code = "TO", Alpha3Code = "TON",
                    UnCode = "776"
                },
                new Country()
                {
                    Id = 798,
                    Name = "Tuvalu", RegionId = 24, Alpha2Code = "TV", Alpha3Code = "TUV",
                    UnCode = "798"
                },
                new Country()
                {
                    Id = 876,
                    Name = "Wallis and Futuna Islands", RegionId = 24, Alpha2Code = "WF",
                    Alpha3Code = "WLF", UnCode = "876"
                },
                new Country()
                {
                    Id = 882,
                    Name = "Samoa", RegionId = 24, Alpha2Code = "WS", Alpha3Code = "WSM",
                    UnCode = "882"
                }
            );

            #endregion
            
            #region Turkey and USA Cities

            builder.Entity<City>().HasData(
                new City() {Id = 1, Name = "Adana", CountryId = 792},
                new City() {Id = 2, Name = "Adıyaman", CountryId = 792},
                new City() {Id = 3, Name = "Afyonkarahisar", CountryId = 792},
                new City() {Id = 4, Name = "Ağrı", CountryId = 792},
                new City() {Id = 5, Name = "Aksaray", CountryId = 792},
                new City() {Id = 6, Name = "Amasya", CountryId = 792},
                new City() {Id = 7, Name = "Ankara", CountryId = 792},
                new City() {Id = 8, Name = "Antalya", CountryId = 792},
                new City() {Id = 9, Name = "Ardahan", CountryId = 792},
                new City() {Id = 10, Name = "Artvin", CountryId = 792},
                new City() {Id = 11, Name = "Aydın", CountryId = 792},
                new City() {Id = 12, Name = "Balıkesir", CountryId = 792},
                new City() {Id = 13, Name = "Bartın", CountryId = 792},
                new City() {Id = 14, Name = "Batman", CountryId = 792},
                new City() {Id = 15, Name = "Bayburt", CountryId = 792},
                new City() {Id = 16, Name = "Bilecik", CountryId = 792},
                new City() {Id = 17, Name = "Bingöl", CountryId = 792},
                new City() {Id = 18, Name = "Bitlis", CountryId = 792},
                new City() {Id = 19, Name = "Bolu", CountryId = 792},
                new City() {Id = 20, Name = "Burdur", CountryId = 792},
                new City() {Id = 21, Name = "Bursa", CountryId = 792},
                new City() {Id = 22, Name = "Çanakkale", CountryId = 792},
                new City() {Id = 23, Name = "Çankırı", CountryId = 792},
                new City() {Id = 24, Name = "Çorum", CountryId = 792},
                new City() {Id = 25, Name = "Denizli", CountryId = 792},
                new City() {Id = 26, Name = "Diyarbakır", CountryId = 792},
                new City() {Id = 27, Name = "Düzce", CountryId = 792},
                new City() {Id = 28, Name = "Edirne", CountryId = 792},
                new City() {Id = 29, Name = "Elazığ", CountryId = 792},
                new City() {Id = 30, Name = "Erzincan", CountryId = 792},
                new City() {Id = 31, Name = "Erzurum", CountryId = 792},
                new City() {Id = 32, Name = "Eskişehir", CountryId = 792},
                new City() {Id = 33, Name = "Gaziantep", CountryId = 792},
                new City() {Id = 34, Name = "Giresun", CountryId = 792},
                new City() {Id = 35, Name = "Gümüşhane", CountryId = 792},
                new City() {Id = 36, Name = "Hakkâri", CountryId = 792},
                new City() {Id = 37, Name = "Hatay", CountryId = 792},
                new City() {Id = 38, Name = "Iğdır", CountryId = 792},
                new City() {Id = 39, Name = "Isparta", CountryId = 792},
                new City() {Id = 40, Name = "İstanbul", CountryId = 792},
                new City() {Id = 41, Name = "İzmir", CountryId = 792},
                new City() {Id = 42, Name = "Kahramanmaraş", CountryId = 792},
                new City() {Id = 43, Name = "Karabük", CountryId = 792},
                new City() {Id = 44, Name = "Karaman", CountryId = 792},
                new City() {Id = 45, Name = "Kars", CountryId = 792},
                new City() {Id = 46, Name = "Kastamonu", CountryId = 792},
                new City() {Id = 47, Name = "Kayseri", CountryId = 792},
                new City() {Id = 48, Name = "Kilis", CountryId = 792},
                new City() {Id = 49, Name = "Kırıkkale", CountryId = 792},
                new City() {Id = 50, Name = "Kırklareli", CountryId = 792},
                new City() {Id = 51, Name = "Kırşehir", CountryId = 792},
                new City() {Id = 52, Name = "Kocaeli", CountryId = 792},
                new City() {Id = 53, Name = "Konya", CountryId = 792},
                new City() {Id = 54, Name = "Kütahya", CountryId = 792},
                new City() {Id = 55, Name = "Malatya", CountryId = 792},
                new City() {Id = 56, Name = "Manisa", CountryId = 792},
                new City() {Id = 57, Name = "Mardin", CountryId = 792},
                new City() {Id = 58, Name = "Mersin", CountryId = 792},
                new City() {Id = 59, Name = "Muğla", CountryId = 792},
                new City() {Id = 60, Name = "Muş", CountryId = 792},
                new City() {Id = 61, Name = "Nevşehir", CountryId = 792},
                new City() {Id = 62, Name = "Niğde", CountryId = 792},
                new City() {Id = 63, Name = "Ordu", CountryId = 792},
                new City() {Id = 64, Name = "Osmaniye", CountryId = 792},
                new City() {Id = 65, Name = "Rize", CountryId = 792},
                new City() {Id = 66, Name = "Sakarya", CountryId = 792},
                new City() {Id = 67, Name = "Samsun", CountryId = 792},
                new City() {Id = 68, Name = "Şanlıurfa", CountryId = 792},
                new City() {Id = 69, Name = "Siirt", CountryId = 792},
                new City() {Id = 70, Name = "Sinop", CountryId = 792},
                new City() {Id = 71, Name = "Şırnak", CountryId = 792},
                new City() {Id = 72, Name = "Sivas", CountryId = 792},
                new City() {Id = 73, Name = "Tekirdağ", CountryId = 792},
                new City() {Id = 74, Name = "Tokat", CountryId = 792},
                new City() {Id = 75, Name = "Trabzon", CountryId = 792},
                new City() {Id = 76, Name = "Tunceli", CountryId = 792},
                new City() {Id = 77, Name = "Uşak", CountryId = 792},
                new City() {Id = 78, Name = "Van", CountryId = 792},
                new City() {Id = 79, Name = "Yalova", CountryId = 792},
                new City() {Id = 80, Name = "Yozgat", CountryId = 792},
                new City() {Id = 81, Name = "Zonguldak", CountryId = 792},
                new City() {Id = 82, Name = "Alabama", CountryId = 840},
                new City() {Id = 83, Name = "Alaska", CountryId = 840},
                new City() {Id = 84, Name = "Arizona", CountryId = 840},
                new City() {Id = 85, Name = "Arkansas", CountryId = 840},
                new City() {Id = 86, Name = "California", CountryId = 840},
                new City() {Id = 87, Name = "Colorado", CountryId = 840},
                new City() {Id = 88, Name = "Connecticut", CountryId = 840},
                new City() {Id = 89, Name = "Delaware", CountryId = 840},
                new City() {Id = 90, Name = "Florida", CountryId = 840},
                new City() {Id = 91, Name = "Georgia", CountryId = 840},
                new City() {Id = 92, Name = "Hawaii", CountryId = 840},
                new City() {Id = 93, Name = "Idaho", CountryId = 840},
                new City() {Id = 94, Name = "Illinois", CountryId = 840},
                new City() {Id = 95, Name = "Indiana", CountryId = 840},
                new City() {Id = 96, Name = "Iowa", CountryId = 840},
                new City() {Id = 97, Name = "Kansas", CountryId = 840},
                new City() {Id = 98, Name = "Kentucky", CountryId = 840},
                new City() {Id = 99, Name = "Louisiana", CountryId = 840},
                new City() {Id = 100, Name = "Maine", CountryId = 840},
                new City() {Id = 101, Name = "Maryland", CountryId = 840},
                new City() {Id = 102, Name = "Massachusetts", CountryId = 840},
                new City() {Id = 103, Name = "Michigan", CountryId = 840},
                new City() {Id = 104, Name = "Minnesota", CountryId = 840},
                new City() {Id = 105, Name = "Mississippi", CountryId = 840},
                new City() {Id = 106, Name = "Missouri", CountryId = 840},
                new City() {Id = 107, Name = "Montana", CountryId = 840},
                new City() {Id = 108, Name = "Nebraska", CountryId = 840},
                new City() {Id = 109, Name = "Nevada", CountryId = 840},
                new City() {Id = 110, Name = "New Hampshire", CountryId = 840},
                new City() {Id = 111, Name = "New Jersey", CountryId = 840},
                new City() {Id = 112, Name = "New Mexico", CountryId = 840},
                new City() {Id = 113, Name = "New York", CountryId = 840},
                new City() {Id = 114, Name = "North Carolina", CountryId = 840},
                new City() {Id = 115, Name = "North Dakota", CountryId = 840},
                new City() {Id = 116, Name = "Ohio", CountryId = 840},
                new City() {Id = 117, Name = "Oklahoma", CountryId = 840},
                new City() {Id = 118, Name = "Oregon", CountryId = 840},
                new City() {Id = 119, Name = "Pennsylvania", CountryId = 840},
                new City() {Id = 120, Name = "Rhode Island", CountryId = 840},
                new City() {Id = 121, Name = "South Carolina", CountryId = 840},
                new City() {Id = 122, Name = "South Dakota", CountryId = 840},
                new City() {Id = 123, Name = "Tennessee", CountryId = 840},
                new City() {Id = 124, Name = "Texas", CountryId = 840},
                new City() {Id = 125, Name = "Utah", CountryId = 840},
                new City() {Id = 126, Name = "Vermont", CountryId = 840},
                new City() {Id = 127, Name = "Virginia", CountryId = 840},
                new City() {Id = 128, Name = "Washington", CountryId = 840},
                new City() {Id = 129, Name = "Washington, D.C.", CountryId = 840},
                new City() {Id = 130, Name = "West Virginia", CountryId = 840},
                new City() {Id = 131, Name = "Wisconsin", CountryId = 840},
                new City() {Id = 132, Name = "Wyoming", CountryId = 840}
            );

            #endregion
        }
    }
}
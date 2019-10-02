using System.Text;

namespace TagalogNumberWordConverter
{
    public static class FilipinoNumberConverter
    {
        public static string ConvertIntMillion(int toConvert)
        {
            int million = int.MinValue;

            if (toConvert > 999999)
            {
                million = toConvert / 1000000;
            }
            else
            {
                return string.Empty;
            }

            string retVal = ConvertHundredthsPlace(million);

            if (retVal.EndsWith("a") || retVal.EndsWith("o") || retVal.EndsWith("u"))
            {
                retVal += "ng milyon";
            }
            else
            {
                retVal += " na milyon";
            }

            return retVal;
            
        }

        public static string ConvertIntThousands(int toConvert)
        {
            int thousands = int.MinValue;
            int unit = toConvert % 1000000;

            if (unit > 1000)
            {
                thousands = unit / 1000;
            }
            else
            {
                return string.Empty;
            }

            string retVal = ConvertHundredthsPlace(thousands);

            if (retVal.EndsWith("a") || retVal.EndsWith("o") || retVal.EndsWith("u"))
            {
                retVal += "ng libo";
            }
            else
            {
                retVal += " na libo";
            }

            return retVal;
        }
        

        public static string ConvertHundreds(int toConvert)
        {
            int unit = toConvert % 10;
            StringBuilder retVal = new StringBuilder();

            if (toConvert > 999 && unit > 0)
            {
                retVal.Append("at ");
            }

            if (toConvert > 99)
            {
                unit = toConvert % 1000;
                retVal.Append(ConvertHundredthsPlace(unit));
            }
            else if (toConvert > 10)
            {
                unit = toConvert % 100;
                retVal.Append(ConvertTenthsPlace(unit));
            }
            else
            {
                retVal.Append(ConvertOnesPlace(unit));
            }

            return retVal.ToString();
        }

        public static string ConvertAll(int toConvert)
        {
            string converted = ConvertIntMillion(toConvert) + " " + ConvertIntThousands(toConvert) + " " +
                ConvertHundreds(toConvert);
            string trimmed = converted.Replace("  ", " ").Trim();
            return trimmed;
        }

        private static string ConvertOnesPlace(int unit)
        {
            switch (unit)
            {
                case 1:
                    return "Isa";
                case 2:
                    return "Dalawa";
                case 3:
                    return "Tatlo";
                case 4:
                    return "Apat";
                case 5:
                    return "Lima";
                case 6:
                    return "Anim";
                case 7:
                    return "Pito";
                case 8:
                    return "Walo";
                case 9:
                    return "Siyam";
                default:
                    break;
            }

            return "";

        }

        private static string ConvertTenthsPlace(int unit)
        {
            int tens = unit / 10;
            int ones = unit % 10;
            string retVal = string.Empty;

            if (tens > 9)
            {
                return "";
            }

            StringBuilder tensWord;
            if (tens == 1 && ones == 0)
            {
                tensWord = new StringBuilder("Sampu");
            }
            else if (tens == 1 && ones > 0)
            {
                tensWord = new StringBuilder("Labing ");
            }
            else
            {
                tensWord = new StringBuilder(ConvertOnesPlace(tens));
            }

            if (tensWord.ToString().EndsWith("a") || tensWord.ToString().EndsWith("o"))
            {
                tensWord.Append("mpo");
            }
            else if (tens > 1)
            {
                tensWord.Append("napo");
            }

            if (tens > 1 && ones > 0)
            {
                tensWord.Append("'t ");
            }

            if (ones > 0)
            {
                tensWord.Append(ConvertOnesPlace(ones));
            }

            retVal = tensWord.ToString();

            return retVal;
        }

        private static string ConvertHundredthsPlace(int unit)
        {
            StringBuilder sb = new StringBuilder();

            int hundreds = unit / 100;
            if (hundreds > 0)
            {
                sb.Append(ConvertOnesPlace(hundreds));

                if (sb.ToString().EndsWith("a") || sb.ToString().EndsWith("o"))
                {
                    sb.Append("ng daan ");
                }
                else
                {
                    sb.Append(" na daan ");
                }
            }

            int tens = unit % 100;
            if (tens > 0)
            {
                sb.Append(ConvertTenthsPlace(tens));
            }


            return sb.ToString();


        }

    }


}

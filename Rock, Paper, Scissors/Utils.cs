namespace Rock__Paper__Scissors
{
    public class Utils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="userInputTemp"></param>
        /// <returns></returns>
        public static string FormatterAndChecker(string[] data, string userInputTemp)
        {
            bool check = false;
            string userInput = userInputTemp.ToUpper().Trim();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == userInput)
                {
                    check = true;
                }
                if (check == true)
                {
                    return userInput;
                }

            }
            return "error";


        }
    }
}

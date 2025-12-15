using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DolgovIV.Sprint6.Task6.V29.Lib
{
    public class DataService : ISprint6Task6V29
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("i"))
                    {
                        resStr = resStr + " " + line; 
                    }
                }
            }
            return resStr;
        }
    }
}

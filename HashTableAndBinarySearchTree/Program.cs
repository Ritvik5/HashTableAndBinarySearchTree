namespace HashTableAndBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table And Binary Saerch Tree!!!\n");

            //MyMapNode<string, string> hash = new MyMapNode<string, string>(6);
            //hash.Add("0", "to");
            //hash.Add("1", "be");
            //hash.Add("2", "or");
            //hash.Add("3", "not");
            //hash.Add("4", "to");
            //hash.Add("5", "be");
            //string hash5 = hash.Get("5");
            //Console.WriteLine("5th index value is: " + hash5);

            // UC1-Frequency of words in sentence - "to be or not to be" 

            //string obj = "to be or not to be";

            //string[] words = obj.Split(' ');

            //MyMapNode<string, int> wordFrequencyMap = new MyMapNode<string, int>(words.Length);

            //foreach (string word in words)
            //{
            //    int frequency = wordFrequencyMap.Get(word);
            //    wordFrequencyMap.Add(word, frequency + 1);
            //}
            //foreach (var item in wordFrequencyMap.GetAllItems())
            //{
            //    Console.WriteLine($"Word: {item.Key}, Frequency: {item.Value}");
            //}

            //UC2-- Frequency of words in Large Paragraph

            string obj2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            
            string[] words = obj2.Split(' ');

            MyMapNode<string, int> wordFrequencyMap = new MyMapNode<string, int>(words.Length);

            foreach (string word in words)
            {
                int frequency = wordFrequencyMap.Get(word);
                wordFrequencyMap.Add(word, frequency + 1);
            }

            foreach (var item in wordFrequencyMap.GetAllItems())
            {
                Console.WriteLine($"Word: {item.Key}, Frequency: {item.Value}");
            }
        }
    }
}
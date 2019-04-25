using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
        */
        Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

        // Add several more words and their definitions
        wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");

        wordsAndDefinitions.Add("Confused", "The feeling of students when they just started c#");

        wordsAndDefinitions.Add("Relieved", "The feeling of students when they are finished with capstones");

        /*
            Use square bracket lookup to get the definition two
            words and output them to the console
        */

        Console.WriteLine($"{wordsAndDefinitions["Awesome"]} ,  {wordsAndDefinitions["Confused"]}");

        /*
            Loop over dictionary to get the following output:
                The definition of [WORD] is [DEFINITION]
                The definition of [WORD] is [DEFINITION]
                The definition of [WORD] is [DEFINITION]
        */
        foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
        {
            Console.WriteLine($"The definition of {word.Key} is {word.Value}");
        }

                // Make a new list
        List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

        // Create dictionary to represent a few word
        Dictionary<string, string> excitedWord = new Dictionary<string, string>();

        // Add each of the 4 bits of data about the word to the Dictionary
        excitedWord.Add("word", "excited");
        excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
        excitedWord.Add("part of speech", "adjective");
        excitedWord.Add("example sentence", "I am excited to learn C#!");

        // Add Dictionary to your `dictionaryOfWords` list
        dictionaryOfWords.Add(excitedWord);

        // create another Dictionary and add that to the list
        Dictionary<string, string> piscineWord = new Dictionary<string, string>(){
            {"word", "piscine"},
            {"definition", "of or concerning fish"},
            {"part of speech", "adjective"},
            {"example sentence", "The piscine creature crested the wave"}
        };

        dictionaryOfWords.Add(piscineWord);

        /*
            Iterate your list of dictionaries and output the data

            Example output for one word in the list of dictionaries:
                word: excited
                definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                part of speech: adjective
                example sentence: I am excited to learn C#!
        */

        // Iterate the List of Dictionaries
        foreach (Dictionary<string, string> listItem in dictionaryOfWords)
        {
            // Iterate the KeyValuePairs of the Dictionary
            foreach (KeyValuePair<string, string> word in listItem)
            {
                Console.WriteLine($"{word.Key}: {word.Value}");
            }
        }

        Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();

        idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
        idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
        idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
        idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
        idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
        idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
        idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
        idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
        idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
        idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

        foreach(KeyValuePair<string, List<string>> idiom in idioms){
            string sep = " ";
            List<string> value = idiom.Value;
            string sentence = String.Join(sep, idiom.Value);
            Console.WriteLine($"{idiom.Key} : {sentence}.");
        };


        //Randall's Car Lot

        List<Dictionary<string, string>> vehicles = new List< Dictionary<string, string>>();

        Dictionary<string, string> vehicle = new Dictionary<string, string>(){
            {"year", "2008"},
            {"model", "Damfresh"},
            {"make", "Biotraxquote"},
            {"color", "sky magenta"}
        };

        Dictionary<string, string> salesId = new Dictionary<string, string>(){
            {"sales_id", "ecb1c841-1a43-4a7c-896e-712d2ec39c71"}
        };

            vehicles.Add(vehicle);
            vehicles.Add(salesId);


        // Challenge: Planets and Probes and KeyValue Pairs

        //Use the list of planets you created in the previous chapter or create a new one with all eight planets.

        // List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", ...};

        List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};


        List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>(){
            new KeyValuePair<string, string>("Mariner 10", "Mercury"),
            new KeyValuePair<string, string> ("Venera One", "Venus"),
            new KeyValuePair<string, string>("Voyager 1", "Jupiter"),
            new KeyValuePair<string, string>("Mariner", "Venus")
            };

//         Iterate over probeDestinations, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which probes have visited it.

// // Iterate planets
        foreach (string planet in planetList)
        {
//     // List to store probes that visited the planet
         List<string> matchingProbes = new List<string>();

//     // Iterate probeDestinations
            foreach(KeyValuePair<string, string> probe in probeDestinations)
            {
                if(planet == probe.Value){
                    matchingProbes.Add(probe.Key);
            }
            }
           string probes = String.Join("," , matchingProbes);


        Console.WriteLine($"{planet}: {probes}");

        }




    }
}
}

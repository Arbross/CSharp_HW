using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task_Exam_2
{
    interface IDictionary
    {
        enum Type : byte { EnUa, UaEn }
        void Add(string first, List<string> second);
        public void Edit(string key, string new_key);
        void Edit(string key, string old_value, string new_value);
        void Remove(string key, string word);
        void Remove(string key);
        string Find(string key, string word);
        void SaveDictionary(string fname);
        void Save(string key, string fname);
    }
    class Diction : IDictionary
    {
        private SortedDictionary<string, List<string>> dictionaryArray;
        private IDictionary.Type type;
        public Diction(string first, List<string> second, IDictionary.Type type)
        {
            dictionaryArray = new SortedDictionary<string, List<string>>();
            dictionaryArray.Add(first, second);
            this.type = type;
        }
        public void Add(string first, List<string> second)
        {
            dictionaryArray.Add(first, second);
        }
        public void Edit(string key, string new_key)
        {
            if (dictionaryArray.ContainsKey(key))
            {
                List<string> tmp = dictionaryArray[key];
                dictionaryArray.Remove(key);
                dictionaryArray.Add(new_key, tmp);
            }
        }
        public void Edit(string key, string old_value, string new_value)
        {
            if (dictionaryArray[key].Contains(old_value))
            {
                List<string> tmp = dictionaryArray[key];
                dictionaryArray.Remove(key);
                for (int i = 0; i < tmp.Count; i++)
                {
                    if (tmp[i] == old_value)
                    {
                        tmp[i] = new_value;
                    }
                }
                dictionaryArray.Add(key, tmp);
            }
        }
        public void Remove(string key, string word)
        {
            if (dictionaryArray.ContainsKey(key))
            {
                if (dictionaryArray.Count > 1 && dictionaryArray[key].Contains(word))
                {
                    dictionaryArray[key].Remove(word);
                }
            }
        }
        public void Remove(string key)
        {
            if (dictionaryArray.ContainsKey(key))
            {
                dictionaryArray.Remove(key);
            }
        }
        public string Find(string key, string word)
        {
            if (dictionaryArray.ContainsKey(key))
            {
                return dictionaryArray[key].Find(x => x == word);
            }
            return null;
        }
        public void SaveDictionary(string fname)
        {
            if (type == IDictionary.Type.EnUa)
            {
                fname = "EnUa_" + fname;
            }
            else if (type == IDictionary.Type.UaEn)
            {
                fname = "UaEn_" + fname;
            }

            string tmp = null;
            foreach (var item in dictionaryArray)
            {
                tmp += item.Key + " ";
                foreach (var value in item.Value)
                {
                    tmp += value + " ";
                }
                tmp += '\n';
            }
            File.WriteAllText(fname, tmp);
            
        }
        public void Save(string key, string fname)
        {
            if (type == IDictionary.Type.EnUa)
            {
                fname = "EnUa_" + fname;
            }
            else if (type == IDictionary.Type.UaEn)
            {
                fname = "UaEn_" + fname;
            }

            string tmp = null;
            tmp += dictionaryArray[key] + " ";
            foreach (var value in dictionaryArray[key])
            {
                tmp += value + " ";
            }
            File.WriteAllText(fname, tmp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AviraCodilityThree
{
    public interface IStringMap<TValue> where TValue : class
    {
        int Count { get; }
        TValue DefaultValue { get; set; }
        bool AddElement(string key, TValue value);
        bool RemoveElement(string key);
        TValue GetValue(string key);
    }

    public class StringMap<TValue> : IStringMap<TValue> where TValue : class
    {
        public int Count => smDict.Count;
        private Dictionary<string, TValue> smDict = new Dictionary<string, TValue>();
        private TValue tV;
        //public TValue DefaultValue {
        //    get
        //    {
        //        return tV;
        //    }
        //    set
        //    {
        //        tV = value;
        //    }
        //}

        public TValue DefaultValue
        {
            get => tV;
            set => tV = value;
        }


        public bool AddElement(string key, TValue value)
        {
            if (key == null)
                throw new System.ArgumentNullException();
            if (string.IsNullOrEmpty(key))
                throw new System.ArgumentException();
            if(value ==null)
                throw new System.ArgumentNullException();
            if (smDict.ContainsKey(key))
            {
                smDict[key] = value;
                return true;
            }
                
            smDict.Add(key, value);
            return false;
           
        }

        public TValue GetValue(string key)
        {
            if (key == null)
                throw new System.ArgumentNullException();
            if (string.IsNullOrEmpty(key))
                throw new System.ArgumentException();
            TValue result;
            if (smDict.TryGetValue(key, out result))
            {
                return result;
            }
            else
            {
                return this.DefaultValue;
            }
          
        }

        public bool RemoveElement(string key)
        {
            if (key == null)
                throw new System.ArgumentNullException();
            else if (String.IsNullOrEmpty(key))
                throw new System.ArgumentException();
            else if (smDict.ContainsKey(key))
            {
                try
                {
                    smDict.Remove(key);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
               
            return false;
        }
    }
}
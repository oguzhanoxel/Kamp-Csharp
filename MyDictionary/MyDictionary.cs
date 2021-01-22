using System;
using System.Collections.Generic;

namespace MyDictionary
{
    public class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;

        // Contructor
        public MyDictionary() {
            keys = new Key[0];
            values = new Value[0];
        }
        public void add(Key key, Value value) {
            Key[] keysArray = keys;
            Value[] valuesArray = values;

            keys  = new Key[keys.Length+1];
            values = new Value[values.Length+1];

            for (int i = 0; i < keysArray.Length; i++)
            {
                keys[i] = keysArray[i];
            }

            for (int i = 0; i < valuesArray.Length; i++)
            {
                values[i] = valuesArray[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }
    }
}
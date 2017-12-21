using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
	public class MyDictionary<T1, T2> : IEnumerable<Tuple<T1, T2>>
	{
		private T1[] Key;
		private T2[] Value;
		private int Count = 0;
		private bool DefaultT1KeyExists = false;
		private bool VerboseDebug = false;

		public MyDictionary()
		{
			Key = new T1[4];
			Value = new T2[4];
		}

		public MyDictionary(bool verboseDebugging) : this()
		{
			VerboseDebug = verboseDebugging;
		}

		public void Insert(T1 key, T2 value)
		{
			if(CompareT(key, default(T1))) 
			{
				if(DefaultT1KeyExists)
				{
					throw new Exception(String.Format("Key {0} already exists in the dictionary.", key));
				}
				
			}
			
			foreach(T1 existingKey in Key)
			{
				if(CompareT(existingKey, key))
				{
					if(CompareT(key, default(T1)) && !DefaultT1KeyExists)
					{
						DefaultT1KeyExists = true;
						break;
					}
					throw new Exception(String.Format("Key {0} already exists in the dictionary.", key));
				}
			}

			if(Count == Key.Length)
			{
				ExpandDictionary();
			}

			Key[Count] = key;
			Value[Count] = value;
			Count++;
		}

		public bool GetValueByKey(T1 key, out T2 valueFound)
		{
			for(int i=0; i<Count; i++)
			{
				if(CompareT(Key[i], key))
				{
					valueFound = Value[i];
					return true;
				}
			}
			valueFound = default(T2);
			return false;
		}

		public void RemoveKey(T1 key)
		{
			int index = 0;
			bool found = false;
			for(int i=0; i<Count; i++)
			{
				if(CompareT(Key[i], key))
				{
					index = i;
					found = true;
					break;
				}
			}

			if(found)
			{
				DeleteAndRearrangeItemsInArray(index);
				Count--;
			}
		}

		public IEnumerator<Tuple<T1, T2>> GetEnumerator()
		{
			int i = 0;
			foreach (T1 key in Key)
			{
				if (i == Count)
				{
					yield break;
				}
				i++;

				T2 value;
				GetValueByKey(key, out value);
				yield return new Tuple<T1, T2>(key, value);
			}
		}


		private void DeleteAndRearrangeItemsInArray(int index)
		{
			for(int i=index; i<Count; i++)
			{
				Key[i] = Key[i + 1];
				Value[i] = Value[i + 1];
			}

			//Key[Count] = default(T1);
			//Value[Count] = default(T2);
		}

		private void ExpandDictionary()
		{
			if(VerboseDebug)
				Console.WriteLine(String.Format("Expaning keys and value array to {0}", Count * 2));

			T1[] newKey = new T1[Count * 2];
			T2[] newValue = new T2[Count * 2];

			for (int i=0; i<Count; i++)
			{
				newKey[i] = Key[i];
				newValue[i] = Value[i];
			}

			Key = newKey;
			Value = newValue;

			if(VerboseDebug)
			{
				Console.WriteLine(String.Format("After expansion keys size is {0}", Key.Length));
				Console.WriteLine(String.Format("After expansion valus size is {0}", Value.Length));
			}
		}

		private bool CompareT<T>(T leftOperand, T rightOperand)
		{
			return EqualityComparer<T>.Default.Equals(leftOperand, rightOperand);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_1
{
    internal class ResizableIntArray
    {
        //  Member Variables 
        public int[] mStorage = new int[20];
        public int mCurrentIndex = 0;

        public void Add(int pNumber)
        {
            mStorage[mCurrentIndex] = pNumber;
            mCurrentIndex++;

        }

        //Method Added. 
        public void ExpandStorage(int pSizeIncrease)
        {
            int[] increasedStorage = new int[mCurrentIndex + pSizeIncrease];
            for (int i = 0; i < mCurrentIndex; i++)
            {
                increasedStorage[i] = mStorage[i];
            }
            mStorage = increasedStorage;

             bool IsFull()
            {
                if (mCurrentIndex < mStorage.Length)
                {
                    return false;
                }
                return true;
            }

                if (IsFull())
                {
                    ExpandStorage(20);
                }

                 void WriteContentsToConsole()
                {
                    for (int i = 0; i < mCurrentIndex; i++)
                    {
                        Console.Write(mStorage[i]);
                    }
                }

            }
        }
    }


    


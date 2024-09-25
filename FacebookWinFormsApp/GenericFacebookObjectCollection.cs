using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    namespace BasicFacebookFeatures
    {
        public class GenericFacebookObjectCollection<T> : IEnumerable<T>
        {
            private readonly FacebookObjectCollection<T> r_FullCollection;

            public GenericFacebookObjectCollection(FacebookObjectCollection<T> i_Collection)
            {
                r_FullCollection = i_Collection;
            }

            public IEnumerator<T> GetEnumerator()
            {
                foreach (T item in r_FullCollection)
                {
                    yield return item;
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}

namespace ConcurrentDictionary
{
    public class MyConcurrentDictionary<TKey, TValue>
    {
        private readonly Segment[] segments;
        private readonly int segmentMask;

        public MyConcurrentDictionary(int segmentCount = 4)
        {
            segments = new Segment[segmentCount];
            segmentMask = segmentCount - 1;

            for (int i = 0; i < segmentCount; i++)
                segments[i] = new Segment();
        }

        public void Set(TKey key, TValue value)
        {
            int segmentIndex = key.GetHashCode() & segmentMask;
            segments[segmentIndex].Set(key, value);
        }

        public bool Get(TKey key, out TValue value)
        {
            int segmentIndex = key.GetHashCode() & segmentMask;
            return segments[segmentIndex].Get(key, out value);
        }

        private class Segment
        {
            private readonly Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();
            private readonly ReaderWriterLockSlim readerWriterLockSlim = new ReaderWriterLockSlim();

            public void Set(TKey key, TValue value)
            {
                readerWriterLockSlim.EnterWriteLock();
                try { data[key] = value; }
                finally { readerWriterLockSlim.ExitWriteLock(); }
            }

            public bool Get(TKey key, out TValue value)
            {
                readerWriterLockSlim.EnterReadLock();
                try { return data.TryGetValue(key, out value); }
                finally { readerWriterLockSlim.ExitReadLock(); }
            }
        }
    }
}


    public interface IObservable
    {
        public void CreateObserver(IObserver o);
        public void DeleteObserver(IObserver o);

        public void Notify();
    }


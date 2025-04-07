public class RandomizedSet {
    private List<int> list;
    private Random random;

    public RandomizedSet() {
        list = new List<int>();
        random = new Random();
    }
    
    public bool Insert(int val) {
        if (list.Contains(val)) {
        return false;
        }

        list.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        int index = list.IndexOf(val);
// does not exist 
        if (index == -1) { 
            return false;
        }
// to remove the spaces after delete element
        int last = list[list.Count - 1];
        list[index] = last;
        list.RemoveAt(list.Count - 1);
        return true;
    }
    
    public int GetRandom() {
        return list[random.Next(list.Count)];
    }
}
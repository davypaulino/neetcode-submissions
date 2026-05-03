public class MinStack {
    private List<int> _stack;
    private List<int> _minors;

    public MinStack() {
        _stack = new();
        _minors = new();
    }
    
    public void Push(int val) {
        _stack.Add(val);
        
        // If it's the first element, it's the minimum.
        // Otherwise, compare val with the current top of the minors stack.
        if (_minors.Count == 0) {
            _minors.Add(val);
        } else {
            int currentMin = _minors[_minors.Count - 1];
            _minors.Add(Math.Min(val, currentMin));
        }
    }
    
    public void Pop() {
        if (_stack.Count > 0) {
            _stack.RemoveAt(_stack.Count - 1);
            _minors.RemoveAt(_minors.Count - 1);
        }
    }
    
    public int Top() {
        // Return the last element added
        return _stack[_stack.Count - 1];
    }
    
    public int GetMin() {
        // The top of the minors stack always holds the minimum for the current stack state
        return _minors[_minors.Count - 1];
    }
}
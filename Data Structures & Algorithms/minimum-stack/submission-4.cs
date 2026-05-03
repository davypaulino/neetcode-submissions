public class MinStack {
    private List<int> _stack;
    private List<int> _minors;

    public MinStack() {
        _stack = new();
        _minors = new();
    }
    
    public void Push(int val) {
        _stack.Add(val);

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
        return _stack[_stack.Count - 1];
    }
    
    public int GetMin() {
        return _minors[_minors.Count - 1];
    }
}
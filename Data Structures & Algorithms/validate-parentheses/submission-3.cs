public class Solution {
    public bool IsValid(string s) {
        if (string.IsNullOrEmpty(s)) return true;
        Stack<char> stack = new();
        Dictionary<char, char> map = new() {
            { '}', '{' },
            { ']', '[' },
            { ')', '(' }
        };
        for (var i = 0; i < s.Length; i++) {
            if (s[i] == '}' || s[i] == ']' || s[i] == ')') {
                if (stack.Count != 0 && stack.Peek() == map[s[i]])
                    stack.Pop();
                else
                    return false;
                continue;
            }
            stack.Push(s[i]);
        }
        return stack.Count == 0;
    }
}

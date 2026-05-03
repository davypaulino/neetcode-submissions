public class Solution {
    public int CalPoints(string[] operations) {
        if (operations.Length == 0)
                return 0;

        Stack<int> records = new();
        for (var i = 0; i < operations.Length; i++) {
            switch (operations[i])
            {
                case "+":
                    records.Push(this.Sum(records));
                    break;
                case "D":
                    records.Push(this.Double(records));
                    break;
                case "C":
                    records.Pop();
                    break;
                default:
                    if(int.TryParse(operations[i], out int result))
                        records.Push(result);
                    break;
            }
        }

        return records.Sum();
    }

    private int Double(Stack<int> records) {
        return records.Peek() * 2;
    }

    private int Sum(Stack<int> records) {
        var top = records.Pop();
        var sum = records.Peek() + top;
        records.Push(top);
        return sum;
    }
}
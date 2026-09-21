public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();

        foreach (string s in tokens) {
            if (s == "+" || s == "-" || s == "*" || s == "/") {
                int num2 = stack.Pop();
                int num1 = stack.Pop();

                switch (s) {
                    case "+":
                        num1 += num2;
                        break;
                    case "-":
                        num1 -= num2;
                        break;
                    case "*":
                        num1 *= num2;
                        break;
                    case "/":
                        num1 /= num2;
                        break;
                }

                stack.Push(num1);
            } else {
                stack.Push(int.Parse(s));
            }
        }

        return stack.Pop();
    }
}

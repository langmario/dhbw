public class ggt {
    static int ggT(int a, int b) {
        if (a == b)
            return (a);
        else {
            if (a > b)
                return (ggT(a - b, b));
            else
                return (ggT(b - a, a));
        }
    }
}

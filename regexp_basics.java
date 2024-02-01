// Title: "Regexp Basics - is it a digit?"
// 8 kyu

public class StringUtils {
    public static boolean isDigit(String s) {
        return s.matches ("[0-9]");
    }
}
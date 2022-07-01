namespace KarticeWebApp.Pages;

public class Utils {
    public static void RotateImage(ref int rotation, out string imageStyle) {
        rotation = rotation == 0 ? 90 : 0;
        imageStyle = $"transform: rotate({rotation}deg) translateX({(rotation == 90 ? 30 : 0)}%);";
    }
}
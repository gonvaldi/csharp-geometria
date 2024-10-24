namespace csharp_geometria;

public partial class Form1 : Form
{
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
            
            // Crear un lápiz (Pen) de color rojo y con grosor de 3
        Pen pen = new Pen(Color.Red, 3);

            // Dibujar un rectángulo en las coordenadas (10, 10) con un ancho de 200 y alto de 100
        e.Graphics.DrawRectangle(pen, 10, 10, 200, 100);
    }
}
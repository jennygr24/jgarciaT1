namespace jgarciaT1.Vistas;

public partial class VistaPrincipal : ContentPage
{
	public VistaPrincipal()
	{
		InitializeComponent();
	}

    private void BotonCalcular_Clicked(object sender, EventArgs e)
    {
        string nombre = nombreUsuario.Text;
        string apellido = apellidoUsuario.Text;
        int edad = int.Parse(edadUsuario.Text);
        decimal salario = decimal.Parse(salarioUsuario.Text);

        decimal calculoIESS = salario * 0.0945m;

        DisplayAlert("Aportacion al IESS", "Bienvenido \n" + nombre+" "+apellido+ "\n "+"Tu edad es " + edad+ "\n"+ "El aporte de tu salario es "+ calculoIESS.ToString("N2"), "Salir");

    }
}
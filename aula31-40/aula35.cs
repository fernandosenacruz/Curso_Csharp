using System;
// Cadeia de herança e Construtor da classe pai

class Carro{ // classe base
    private int rodas;
    public int velMax, portas;
    public bool ligado;
    
    public Carro(int rodas){
        this.rodas=rodas;
    }
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }
    public string getLigado(){
        return(ligado?"On":"Off"); // if ou operador ternário
    }
    public int getRodas(){
        return rodas;
    }
}
class Citroen:Carro{
    public int ano;
    public string cor;
    public double motor;
    public Citroen(int ano,double motor,string cor,int portas):base(4){ // derivada(herdada)
        desligar();
        this.motor=motor;
        this.ano=ano;
        this.cor=cor;
        this.portas=portas;
        velMax=155;
    }
    class CitroenTunado:Citroen{
        public bool nitro;
        public CitroenTunado():base(2010,2.2,"verde camuflado", 2){
            if(nitro=true){
                velMax=(velMax+30)/100;
            }else{
                velMax=velMax;
            }
        }
    }
}
class aula34{
    static void Main(){
        Citroen c3 =new Citroen(2011,1.4,"cinza",4);
        CitroenTunado c3tunado=new CitroenTunado();
        
        Console.Write("Citroen c3 {0} {1} {2} {3}P atinge: {4}km/h.\t{5}\n",c3.ano,c3.motor,c3.cor,c3.portas,c3.velMax,c3.getLigado());
        Console.WriteLine("Rodas esportivas: '{0}'.",c3.getRodas());

        c3tunado.nitro=true;
        Console.Write("Citroen c3 tunado {0} {1} {2} {3}P atinge: {4}km/h.\t{5}\n",c3tunado.ano,c3tunado.motor,c3tunado.cor,c3tunado.portas,c3tunado.velMax);
        Console.WriteLine("Rodas esportivas: '{0}'.",c3tunado.getRodas());
    }
}
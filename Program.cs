using DesafioPOO.Models;
using Microsoft.Win32.SafeHandles;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("(83) 9 32423742", "Celular Nokia", "344324", 8);
Iphone i1 = new Iphone("(83) 9 40583213", "Celular Iphone", "3029423", 5);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("WhatsApp");

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Facebook");
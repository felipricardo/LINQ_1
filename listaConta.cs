using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaConta
{
    public static class Program
    {
      /*Nosso	banco	armazena	uma	lista	de	contas.	Essas	contas	possuem	os	mais	variados	correntistas,	saldos	e
        tipos.	Muitas	vezes,	precisamos	 filtrá-las	de	alguma	 forma.	Por	exemplo,	 se	quisermos	pegar	todas	as
        contas	com	saldo	maior	que	2000	reais,	fazemos:*/  
      
        var lista = new Lista<Conta>();

        // inserimos algumas contas
        lista.Add (...);

        // cria lista que usaremos para guardar os elementos filtrados
        var filtrados = new List<Conta>();
        foreach(var c : lista) 
        {
            if(c.saldo > 200) 
            {
                 filtrados.Add(c); 
            }
        }
    }
}

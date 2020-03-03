using System;
using System.IO;
//para usar o IEnumerable
using System.Collections.Generic;

namespace TrabalhandoComArquivosDirectory {
    class Program {
        static void Main(string[] args) {

            string path = @"c:\temp\myfolder";

            try {
                //listar todas as pastas a partir da subpasta myfolder.
                //usamos a classe Directory e usamos o operador EnumerateDirectories
                //dentro dessa operação temos algumas sobrecargas...
                //(caminho base, padrão de busca na forma de string "extensão do arquivo", opção de busca "tipo enumerado"
                //SeachOption.AllDirectories(todos os diretorios ou somente o diretorio atual (TopDirectoryOnly)

                //para listar temos que utilizar a opção de lista do tipo IEnumerable <string> folders
                //IEnumerable <string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);**//

                //outra forma de listar sem precisar utilizar o tipo de lista, usamos a palavra generica "var".
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDER:");
                //faremos um foreach na coleção
                //para cada string s in folders 
                foreach (string s in folders) {
                    //imprima s (pastas)
                    Console.WriteLine(s);
                }
                //aqui estamos listando os arquivos!
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                //faremos um foreach na coleção
                //para cada string s in files 
                foreach (string s in files) {
                    //imprima s (listas)
                    Console.WriteLine(s);
                }
                //Criando uma nova pasta.
                //ao invés de colocar \\ podemos utilizar o @"\newfolder"
                Directory.CreateDirectory(path + "\\newfolder");
            
            }
            catch(IOException e) {
                Console.WriteLine("An Error Ocurred");
                Console.WriteLine(e.Message);
            }
            
        }
    }
}

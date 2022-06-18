using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
string path =@"/home/alvaro/Documentos/Taller1/";
var archivos = new List<string>();

do{
    try{
        System.Console.WriteLine(@"     Carpeta: "+path);
        foreach(var carpPrincipal in Directory.GetFiles(path)){
            System.Console.WriteLine(Path.GetFileName(carpPrincipal));
            archivos.Add(Path.GetFileName(carpPrincipal));
        }
        foreach(var carpetas in Directory.GetDirectories(path)){
            System.Console.WriteLine(@"     Carpeta: "+carpetas);
            foreach(var archivo in Directory.GetFiles(carpetas)){
                System.Console.WriteLine(Path.GetFileName(archivo));
                archivos.Add(Path.GetFileName(archivo));
            }
        }
        StreamWriter sw = new StreamWriter(path+@"index.csv",true);
        int i = 0;
        foreach(var arch in archivos){
            i++;
            sw.WriteLine(i+")    "+arch);
        }
        sw.Close();
        
        
    }catch(Exception error){
        System.Console.WriteLine("No ingresaste una ruta correta"+error.Message);
    }
}while(!Directory.Exists(path));
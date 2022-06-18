using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
string path =@"/home/alvaro/Documentos/Taller1/";
var archivos = new List<string>();

do{
    try{
        foreach(var carpetas in Directory.GetDirectories(path)){
            System.Console.WriteLine(@"     Carpeta: "+carpetas);
            foreach(var archivo in Directory.GetFiles(carpetas)){
                string nombreExt = Path.GetFileName(archivo);
                System.Console.WriteLine(nombreExt);
                archivos.Add(nombreExt);
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
//Codigo para implementar un Session Object en el domain

List<llaves>  listaLLaves= new List<llaves>();
            listaLLaves.Add(new llaves(){prop1 = 1,prop2=1009});
            listaLLaves.Add(new llaves(){prop1 = 2,prop2=2009});

            AppDomain.CurrentDomain.SetData("diccionario", listaLLaves);

            List<llaves> copiaLlaves = (List<llaves>) AppDomain.CurrentDomain.GetData("diccionario");

            foreach (llaves item in copiaLlaves)
            {
                Console.WriteLine(String.Format("item prop1:{0},prop2:{1}", item.prop1, item.prop2));
                
            }
            copiaLlaves.Add(new llaves()
            {
                prop1=3,prop2=3009
            });

             AppDomain.CurrentDomain.SetData("diccionario", listaLLaves);
             List<llaves> copiaLlaves2 = (List<llaves>)AppDomain.CurrentDomain.GetData("diccionario");

             foreach (llaves item in copiaLlaves2)
             {
                 Console.WriteLine(String.Format("item prop1:{0},prop2:{1}", item.prop1, item.prop2));

             }

            //modify
             copiaLlaves2.FirstOrDefault(l => l.prop1 == 1).prop2 = 4009;

             AppDomain.CurrentDomain.SetData("diccionario", copiaLlaves2);
             List<llaves> copiaLlaves3 = (List<llaves>)AppDomain.CurrentDomain.GetData("diccionario");

             foreach (llaves item in copiaLlaves3)
             {
                 Console.WriteLine(String.Format("item prop1:{0},prop2:{1}", item.prop1, item.prop2));

             }

             Console.Read();

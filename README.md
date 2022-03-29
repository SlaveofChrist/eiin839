# Rendu TD6
  
  * Auteur : Eliel WOTOBE
  * Contenu : 
     C'est un rendu très minimal qui permet d'exécuter trois projets : ClientSOAP, ServeurSOAP, ServeurREST.

     Le ClientSOAP permet de tester le Serveur SOAP et fait afficher trois valeurs :
       * 1 + 2
       * 4 - 2 
       * 3 * 3
     
     Le ServeurREST permet d'utiliser les opérations d'addition, soustraction et de multiplication à partir du navigateur.
     Pour exécuter les opérations sur ce serveur il faut lancer les lien suivants: 
      * addition : http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/add?x= {int}&y={int}
      * soustraction : http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/substract?x= {int}&y={int}
      * multiplication : http://localhost:8733/Design_Time_Addresses/MathsLibrary/MathsOperations/multiply?x= {int}&y={int}

   

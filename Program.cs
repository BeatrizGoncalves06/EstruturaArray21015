using  System ;

namespace  ArrayColection
{
     programa de aula
    {
        static  void  Main ( string [] args )
        {
            // string [] alunosAMS = nova string [5] {
              // "Mariana",
              // "Gabriela",
              // "Geovanna",
              // "Maria Julia",
              // "Cibelle"
          // };

          // Console.WriteLine (alunosAMS [2]);

          // alunosAMS [2] = "Julia";

         // Console.WriteLine ($ "o novo valor do índice 2 {alunosAMS [2]}");

           // foreach (string Aluno em alunosAMS)
           // {
           //      Console.WriteLine (Aluno);
          // }

          string [] alunosAMS   =   nova   string [ 5 ];
          alunosAMS [ 0 ] =   " Mariana " ;
          alunosAMS [ 1 ] =   " Gabriela " ;
          alunosAMS [ 2 ] =   " Geovanna " ;
          alunosAMS [ 3 ] =   " Maria Julia" ;
          alunosAMS [ 4 ] =   " Cibelle " ;

          Console . WriteLine ( alunosAMS [ 2 ]);

          alunosAMS [ 2 ] =   " Viviane " ;

          Console . WriteLine ( $ " O novo valor atribuído a essa variável é: { alunosAMS [ 2 ]} " );

          for ( int   i   =   0 ; i   <   alunosAMS . Comprimento ; i  ++ )
          {
               Console . WriteLine ( $ " Os nomes são: { alunosAMS [ i ]} " );
          }

        }
    }
}
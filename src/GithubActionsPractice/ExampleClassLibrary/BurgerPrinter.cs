namespace ExampleClassLibrary
{
    public class BurgerPrinter : IPrinter
    {
        public void Print()
        {
            var originalBackggoundColor = Console.BackgroundColor;
            var originalForegroundColor = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                                                                  
                                                                  
                                                                  
                                                                  
                                                                  
                                                                  
                                                                  
                          ░░░░░░░░░░░░░░                          
                      ░░░░░░░░░░░░░░░░░░░░░░                      
                  ░░░░░░░░░░▒▒░░░░░░░░░░▒▒░░░░                    
                ░░░░░░░░░░░░░░░░▓▓▓▓▒▒░░░░░░░░░░░░                
              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              
              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              
              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              
              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              
              ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░              
            ▒▒  ░░▒▒▒▒░░░░░░▒▒▒▒▒▒░░░░░░░░▒▒▒▒░░░░  ██            
          ░░▒▒  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ██          
          ▓▓    ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░      ██        
          ▓▓  ▓▓▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▓▓    ██        
          ▓▓  ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒    ██        
          ▓▓    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒      ██        
          ▓▓  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░    ██        
          ░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░  ██          
            ░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░                
                          ▓▓          ▓▓                          
                          ██          ▓▓                          
                          ██          ▓▓                          
                          ██          ▓▓                          
                          ██          ▓▓                          
                          ██░░        ██▒▒                        
                          ▓▓░░        ▓▓▒▒                        
                                                                  
                                                                  
                                                                  
            ");
            Console.BackgroundColor = originalBackggoundColor;
            Console.ForegroundColor = originalForegroundColor;
        }
    }
}

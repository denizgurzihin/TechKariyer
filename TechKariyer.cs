using System; 

namespace C_{
    public class TechKariyer{
        static void Main(string[] args){
        
            string[] moves = {"Rock", "Paper", "Scissors"};             //moves of a player
            
            string player_A = "Paper";                                  //assign player_A move as paper
    
            Random rand = new Random();                                 //creating random object
            
            int win_counter = 0;                                        //variable for counting number of times that player_A has won
            int lose_counter = 0;                                       //variable for counting number of times that player_B has won
            int draw_counter = 0;                                       //variable for counting number of times that match has tied

            int temp_1 = 0;                                             //temp variable for result

            for(int i=0; i<100; i++){
                int index = rand.Next()%3;                              //finding a random number between 0 to 2
                string player_B = moves[index];                         //assiging player_B move as random from moves   
                
                temp_1 = Shake_Hands(player_A, player_B);               //thay have made their moves and deciding which player has won the round
                
                //counting according to the temp_1, 0 for draw, 1 for player_A won, -1 fpr player_B won
                if(temp_1==1){
                    win_counter = win_counter + 1;        
                }
                else if (temp_1==-1){
                    lose_counter = lose_counter + 1;  
                }
                else if (temp_1==0){
                    draw_counter = draw_counter + 1;
                }
            }

            //printing the result to the screen
            Console.WriteLine("Player A wins "+ win_counter + " of 100 games");
            Console.WriteLine("Player B wins "+ lose_counter + " of 100 games");
            Console.WriteLine("Tie "+ draw_counter + " of 100 games");

        }

        static int Shake_Hands(string move1, string move2){
            int result = 0;
            
            if(move2=="Paper"){                     //they have both selected paper
                result = 0;
            }
            else if(move2=="Rock"){                 //player_A win, player_B selected rock so that he/she lose
                result = 1;
            }
            else if(move2=="Scissors"){             //player_A lose, player_B selected sciccors so that he/she win
                result = -1;
            }
        
            return result;
        }
    }
}





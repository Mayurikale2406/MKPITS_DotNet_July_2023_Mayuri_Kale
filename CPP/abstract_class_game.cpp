#include<iostream>
using namespace std;
class Game
{
	public:
		virtual void start()=0;
		virtual void play()=0;
		virtual void end()=0;
		
};
class tic_tac_toe:public Game
{
	public:
		void start()
		{
			cout<<"tictactoe game is start"<<endl;
		}
		void play()
		{
			cout<<"tictactoe game is play"<<endl;
		}
		void end()
		{
			cout<<"tictactoe game is end"<<endl;
		}	
};
class Chease:public Game
{
	public:
		void start()
		{
			cout<<"chease game is start"<<endl;
		}
		void play()
		{
			cout<<"chease game is play"<<endl;
		}
		void end()
		{
			cout<<"chease game is end"<<endl;
		}	
		
};
int main()
{
	tic_tac_toe t;
	cout<<"      GAME TIC_TAC_TOE      "<<endl;
	t.start();
	t.play();
	t.end();
	Chease c;
	cout<<"       GAME CHEASE      "<<endl;
	c.start();
	c.play();
	c.end();
	cout<<"GAME CHEASE"<<endl;
	return 0;
}


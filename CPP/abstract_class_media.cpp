#include<iostream>
using namespace std;
class mediaplayer
{
	public:
		virtual void play()=0;
		virtual void pause()=0;
		virtual void stop()=0;
};
class Audio:public mediaplayer
{
    public:
    	void play()
    	{
    		cout<<"play audio "<<endl;
		}
		void pause()
		{
			cout<<"pause audio"<<endl;
		}
		void stop()
		{
			cout<<"stop audio"<<endl;
		}
};
class video:public mediaplayer
{
	public:
		void play()
		{
			cout<<"play video"<<endl;
		}
		void pause()
		{
			cout<<"pause video"<<endl;
		}
		void stop()
		{
			cout<<"stop video"<<endl;
		}
 };
 int main()
 {
 	Audio a;
 	a.pause();
 	a.play();
 	a.stop();
 	video v;
 	v.pause();
 	v.play();
 	v.stop();
 	return 0;
 }

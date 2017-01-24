using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public int selected, randomNumber;

    protected void Page_Load(object sender, EventArgs e)
    {

    }




    protected void Button_play_Click(object sender, EventArgs e)
    {
        if (rb_scissor.Checked == true) { selected = 3; }
        else if (rb_paper.Checked == true) { selected = 2; }
        else if(rb_rock.Checked == true) { selected = 1; }

        generate();
        result(selected, randomNumber);
        Button_play.Visible = false;
        Button_replay.Visible = true;
        
    }
    public void generate()
    {
        Random ran = new Random();
        randomNumber = ran.Next(1, 4);

        if (randomNumber == 3)
        {
            PC_Scissor.BackColor = System.Drawing.Color.BlanchedAlmond;
        }
        else if (randomNumber == 2)
        {
            PC_Paper.BackColor = System.Drawing.Color.BlanchedAlmond;
        }
        else if (randomNumber == 1)
        {
            PC_Rock.BackColor = System.Drawing.Color.BlanchedAlmond;
        }

    }

    public void result(int user, int gen)
    {
        if (user == gen)
        {
            Label_result.Text = "It's a tie";
            Label_result.Visible = true;
        }
        else
        {
            if (user == 3)
            {
                if (gen == 2)
                {
                    Label_result.Text = "You win";
                    Label_result.Visible = true;
                }
                else
                {
                    Label_result.Text = "You lose";
                    Label_result.Visible = true;
                }

            }
            else if (user == 2)
            {
                if (gen==1)
                {
                    Label_result.Text = "You win";
                    Label_result.Visible = true;
                }
                else
                {
                    Label_result.Text = "You lose";
                    Label_result.Visible = true;
                }  
            }
            else if (user == 1)
            {
                if (gen == 2) {
                    Label_result.Text = "You lose";
                    Label_result.Visible = true;
                }
                else {
                    Label_result.Text = "You win";
                    Label_result.Visible = true;
                }
            }

        }
    }




    protected void Button_replay_Click(object sender, EventArgs e)
    {
        Button_replay.Visible = false;
        Button_play.Visible = true;
        Label_result.Visible = false;
        PC_Rock.BackColor = System.Drawing.Color.White;
        PC_Paper.BackColor = System.Drawing.Color.White;
        PC_Scissor.BackColor = System.Drawing.Color.White;
    }
}
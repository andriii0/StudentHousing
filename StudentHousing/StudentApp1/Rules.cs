using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp1
{
    public partial class Rules : Form
    {
        private User authenticatedUser;


        public Rules()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form1 = new MainForm(authenticatedUser);
            form1.Show();
        }

        private void Rules_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = @"Rules for College Dormitory:
            1. Quiet Hours: Maintain silence from a specific time in the evening till morning to respect neighbors' sleep.
            2. Common Area Cleanliness: Allocate cleaning duties to ensure all residents participate in keeping the common areas clean.
            3. Guest Policies: Invite guests respectfully, being mindful of neighbors and adhering to the dormitory's rules.
            4. Electronics and Noise: Ensure that loud music or electronic devices don’t disturb other residents, especially during late hours.
            5. Resource Conservation: Conserve water and electricity by turning off lights and appliances when leaving rooms.
            6. No Smoking Policy: Smoking inside the dormitory is prohibited to ensure safety and comfort for all residents.
            7. Fire Safety Regulations: Avoid blocking pathways and ensure that items are kept away from electrical sources to prevent fire hazards.
            8. Personal Hygiene: Maintain personal hygiene to uphold cleanliness and health standards within the dormitory.
            9. Kitchen Usage Guidelines: Clean up after cooking and ensure kitchen supplies are accessible to everyone.
            10. Storage Rules: Store personal belongings in designated areas to keep common spaces tidy and safe for everyone.";
        }
    }

}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuotEase.Pages
{
    public class SignupModel : PageModel
    {
        [BindProperty]
        public SignUpModel SignUp { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // �ӡ�úѹ�֡������ŧ�ҹ������ ���ͻ����żŵ��仵�����س��ͧ��÷�
            // ������ҧ��:
            // _context.Users.Add(SignUp);
            // await _context.SaveChangesAsync();

            return RedirectToPage("/Login"); // ��ѧ�ҡ�ѹ�֡��������������ö redirect �˹����ѡ��
        }
    }
}

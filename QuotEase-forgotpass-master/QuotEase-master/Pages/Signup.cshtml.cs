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

            // ทำการบันทึกข้อมูลลงฐานข้อมูล หรือประมวลผลต่อไปตามที่คุณต้องการทำ
            // ตัวอย่างเช่น:
            // _context.Users.Add(SignUp);
            // await _context.SaveChangesAsync();

            return RedirectToPage("/Login"); // หลังจากบันทึกข้อมูลเสร็จสามารถ redirect ไปหน้าหลักได้
        }
    }
}

public IActionResult Index()
{
    // Add the message
    ViewData["DatabaseAccessMessage"] = "Database access has already been done on Nov 28, 2024, by Iffat Binte Sikder.";

    return View();
}


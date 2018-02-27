|      |                                      |
| -------------- | ------------------------------------------------------------ |
| BoundField  |e.Row.Cells[欄索引].Text |
| CheckBoxField  | CheckBox chk = (CheckBox)e.Row.Cells[欄索引].Controls[0];                 chk.Text = "Hello World!!"; |
| HyperLinkField | HyperLink lnk = (HyperLink)e.Row.Cells[欄索引].Controls[0];                  lnk.Text = "Hello World!!"; |
| ImageField     | Image img = (Image)e.Row.Cells[欄索引].Controls[0];            img.ImageUrl=""; |
| ButtonField    | Button btn = (Button)e.Row.Cells[欄索引].Controls[0];            btn.Text="Hello World!!"; |
| CommandField   | 要視ButtonType(Button、Link、Image)決定 以Link為例： LinkButton lnkbtn = (LinkButton)e.Row.Cells[欄索引].Controls[0];                 lnkbtn.Text = "Hello World!!"; |
| TemplateField  | (控制項型別)e.Row.FindControl("控制項id");                   |


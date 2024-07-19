unit Unit1;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, Menus;

type
  TForm1 = class(TForm)
    Memo1: TMemo;
    Button1: TButton;
    Button2: TButton;
    CheckBox1: TCheckBox;
    CheckBox2: TCheckBox;
    CheckBox3: TCheckBox;
    CheckBox4: TCheckBox;
    CheckBox5: TCheckBox;
    CheckBox6: TCheckBox;
    Button3: TButton;
    ScrollBar1: TScrollBar;
    Label1: TLabel;
    Edit1: TEdit;
    SaveDialog1: TSaveDialog;
    PopupMenu1: TPopupMenu;
    procedure ScrollBar1Change(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure SaveDialog1CanClose(Sender: TObject; var CanClose: Boolean);
    procedure Edit1KeyPress(Sender: TObject; var Key: Char);
    procedure Edit1KeyUp(Sender: TObject; var Key: Word;
      Shift: TShiftState);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;
  l,k:integer;
  s,o,h:string;
  f:textfile;
implementation

{$R *.dfm}
function logtoint(a:boolean):integer;
begin
  if a=true then logtoint:=1 else logtoint:=0;
end;

procedure TForm1.ScrollBar1Change(Sender: TObject);
begin
  l:=scrollbar1.Position;
  edit1.Text:=inttostr(l);
end;

procedure TForm1.Button1Click(Sender: TObject);
var
i:integer;
n:array[0..15] of integer;
label m1,m2;
begin
o:='';
memo1.Clear;
s:='';
n[1]:=logtoint(checkbox1.checked);
n[2]:=logtoint(checkbox2.checked);
n[3]:=logtoint(checkbox3.checked);
n[4]:=logtoint(checkbox4.checked);
n[5]:=logtoint(checkbox5.checked);
n[6]:=logtoint(checkbox6.checked);
for i:=1 to l do
  begin
    m1:
    randomize;
    n[0]:=(random(6999) div 1000);
    if n[n[0]]=0 then goto m1;
    n[7]:=n[1]*((random(31999) div 1000)+192);
    n[8]:=n[2]*((random(25999) div 1000)+65);
    n[9]:=n[3]*((random(31999) div 1000)+224);
    n[10]:=n[4]*((random(25999) div 1000)+97);
    n[11]:=n[5]*((random(9999) div 1000)+48);
    n[12]:=n[6]*((random(6999) div 1000)+58);
    n[13]:=n[6]*((random(4999) div 1000)+91);
    if n[0]=6 then n[0]:=(random(1999) div 1000)+12 else n[0]:=n[0]+6;
    k:=n[n[0]];
    s:=chr(k);
       {    k:=random(255);
    if (((k>191) and (k<224)) or (k=168))
   and (checkbox1.checked=true) then goto m2;
    if ((k>64) and (k<91))
   and (checkbox2.checked=true) then goto m2;
    if ((k>223) or (k=184))
   and (checkbox3.checked=true) then goto m2;
    if (k>96) and (k<123)
   and (checkbox4.checked=true) then goto m2;
    if (k>47) and (k<58)
   and (checkbox5.checked=true) then goto m2;
    if ((k>32) and (k<38))
   and (checkbox6.checked=true) then goto m2;
    if ((k>38) and (k<48))
   and (checkbox6.checked=true) then goto m2;
    if ((k>57) and (k<65))
   and (checkbox6.checked=true) then goto m2;
    if ((k>90) and (k<96))
   and (checkbox6.checked=true) then goto m2;
}    if s='' then goto m1;
    m2:
    s:=chr(k);
    o:=o+s;
    s:='';
  end;
memo1.Lines.Add(o);
end;

procedure TForm1.FormCreate(Sender: TObject);
begin
  l:=scrollbar1.Position;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin
  form1.Close;
end;

procedure TForm1.Button2Click(Sender: TObject);
begin
  if o='' then showmessage('Нечего сохранять!') else savedialog1.Execute;
end;

procedure TForm1.SaveDialog1CanClose(Sender: TObject;
  var CanClose: Boolean);
//var
//answ:word;
begin
  assignfile(f,savedialog1.FileName+copy(savedialog1.Filter,length(savedialog1.Filter)-3,4));
  {$I-}
  append(f);
  if IOresult<>0 then
    begin
      rewrite(f);
      {$I+}
      if IOresult<>0 then
        begin
          ShowMessage('Ошибка создания файла');
          exit;
        end;
    end;
  o:=o+' '+DateToStr(Date);
  writeln(f,o);
  closefile(f);
end;

procedure TForm1.Edit1KeyPress(Sender: TObject; var Key: Char);
begin
  case key of
'0'..'9':;
#13:button1.SetFocus;
#8:;
  else key:=chr(0);
  end;
  h:=edit1.Text;
end;

procedure TForm1.Edit1KeyUp(Sender: TObject; var Key: Word;
  Shift: TShiftState);
var
g:integer;
begin
  if edit1.text='' then edit1.text:='1';
  g:=strtoint(edit1.text);
  if g>255 then edit1.Text:='255';
  g:=strtoint(edit1.text);
  l:=g;
  scrollbar1.Position:=l;
end;

end.


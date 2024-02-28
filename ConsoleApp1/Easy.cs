public class Easy() {

    public bool palindromNumber(int x) {
        string stringInput = x.ToString();
        string newWord = "";

        for(int i = stringInput.Length - 1; i >= 0; i--) {
            newWord = newWord + stringInput[i];
        }

        if(stringInput == newWord) {
            System.Console.WriteLine("the number is palindrom");
            return true;
        }   

        System.Console.WriteLine("the number is not palindrom");
        return false;
    }

    public int RomanToInt(string s) {
        int count = s.Length;
        int intValue = 0;
        int i = 0;
        while(i < count) {
            switch(s[i]) {
                case 'I':
                if(i < count - 1) {
                    if(s[i+1] == 'V') {
                        intValue += 4;
                        i++;
                    } else if(s[i+1] == 'X') {
                        intValue += 9;
                        i++;
                    } else {
                        intValue += 1;
                    }
                } else {
                    intValue += 1;
                }
                break;
                case 'V':
                    intValue += 5;
                break;
                case 'X':
                    if(i < count - 1) {
                        if(s[i+1] == 'L') {
                            intValue += 40;
                            i++;
                        } else if(s[i+1] == 'C') {
                            intValue += 90;
                            i++;
                        } else {
                        intValue += 10; 
                        }
                    } else {
                        intValue += 10;
                    }
                
                break;
                case 'L':
                    intValue += 50;
                break;
                case 'C':
                    if(i < count - 1) {
                        if(s[i+1] == 'D') {
                            intValue += 400;
                            i++;
                        } else if(s[i+1] == 'M') {
                            intValue += 900;
                            i++;
                        } else {
                            intValue += 100;
                        }
                    } else {
                        intValue += 100;
                    }
                    
                break;
                case 'D':
                    intValue += 500;
                break;
                case 'M':
                    intValue += 1000;
                break;
            }
            i++;
        }
        System.Console.WriteLine("the int value is " + intValue);
        return intValue;
    }


}


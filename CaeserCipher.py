import string
from time import sleep


def cipherText(shiftcipher):
    plain_text = input("Enter the message you want to cipher: ")
    shift = shiftcipher

    alphabet = string.ascii_letters + string.digits + string.punctuation  # If I printed this is would show "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!"#$%&'()*+,-./:;<=>?@[\]^_`{|}~"
    shifted = alphabet[shift:] + alphabet[:shift]
    table = str.maketrans(alphabet, shifted)  # This makes a translation from alphabet to shifted

    encrypted = plain_text.translate(table)  # In general this means "Encrypted = the plain text translated with table"
    print("Original message:", plain_text)
    print("Shift key:", shift)
    print("Encrypted message:", encrypted)
    sleep(4)
    print()
    type()


def plainText(shiftcipher):
    ciphered_text = input("Enter the message you want to decipher: ")
    shift = shiftcipher
    alphabet = string.ascii_letters + string.digits + string.punctuation
    shifted = alphabet[shift:] + alphabet[:shift]
    table = str.maketrans(alphabet, shifted)
    decrypted = ciphered_text.translate(table)
    print("Original message:", ciphered_text)
    shift = shiftcipher - shiftcipher - shiftcipher
    print("Shift key:", shift)
    print("Decrypted message:", decrypted)
    sleep(4)
    print()
    type()


def type():
    cipheroruncipher = input('''Would you like to cipher a message or decipher a message? 1/2(Type "no" if you want this program to end): ''')
    if cipheroruncipher == '1':
        shiftcipher = int(input("Enter the shift amount(Leave this blank if you want it set to 3): "))
        if shiftcipher == 0:
            shiftcipher = 3
            cipherText(shiftcipher)
        else:
            cipherText(shiftcipher)
    elif cipheroruncipher == '2':
        shiftcipher = int(input("Enter the shift amount(Type 0 if you want it set to 3): "))
        if shiftcipher == 0:
            shiftcipher = -3
            plainText(shiftcipher)
        else:
            shiftcipher = shiftcipher - (shiftcipher * 2)
            plainText(shiftcipher)
    elif cipheroruncipher == 'no':
          try:
              raise BrokenPipeError
          finally:
            print("Okay Goodbye!")
            sleep(2)


type()

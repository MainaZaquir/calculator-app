import tkinter as tk

def evaluate_expression():
    try:
        result = eval(entry.get())
        result_label.config(text="Result: " + str(result))
    except:
        result_label.config(text="Invalid expression")

# Create the main window
window = tk.Tk()
window.title("Calculator")

# Create the UI elements
entry = tk.Entry(window, width=30)
entry.pack(pady=10)

evaluate_button = tk.Button(window, text="Evaluate", command=evaluate_expression)
evaluate_button.pack()

result_label = tk.Label(window, text="Result: ")
result_label.pack(pady=10)

# Start the main loop
window.mainloop()

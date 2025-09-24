# Security prompts for THREAT MODELLING
1. Copilot - Threat model // ASK MODE

- Evaluate this design from Microsoft Threat modelling tool and tell me key security aspects I should consider #file:threat_model.jpg 
    
- Could you provide more context connecting the STRIDE methodology concepts with the previous analysis of my architecture? Try to provide as more information as possible as I am new to threat modelling. 

- Now extend the answer with references to my #codebase

2. Luis DEMO
- GHAS, Secrets, info panels, PRs, agentic mode, ...

3.  Evaluate the general security state of my project (copilot-instructions.md)
  
```bash
#codebase evaluate the security of my project, both frontend in #file:ClientApp and backend #file:MyApp.API and tell me a list of security issues I should address.
```

# Security prompts for general development

1. Cookies	// AGENT MODE
- Lets start by fixing those insecure cookies, step by step and guide me through the process

2. Authentication -> Header -> JWT // AGENT MODE
- #codebase now evaluate the authentication system, instead of using a header, could you modify my system to use JWT?

3. Otras vulns
- Could you check the security of my frontend, and tell me recommendations #file:ClientApp
    - Eval and XSS specific

4. Appsettings, secrets, and so on
- Now evaluate my #codebase to find any secret that shouldn't be there


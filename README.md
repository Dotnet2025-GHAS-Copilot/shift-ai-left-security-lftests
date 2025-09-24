
## Objetivo

> Mostrar que combinando **GHAS** y **Copilot** somos capaces de seguir un **S-SDLC**, detectando problemas de seguridad lo antes posible. El enfoque será de GitHub -> IDE, de tal forma que lo que detectemos en remoto, lo intentaremos corregir en local.


# Texto oficial charla

Como desarrolladores, nuestro objetivo es crear productos seguros y evitar problemas de seguridad costosos en producción—ya sean filtraciones de datos, fallos en el control de acceso, diseños inseguros o cabeceras mal configuradas.

Adoptar un enfoque de seguridad Shift-Left significa identificar vulnerabilidades o debilidades lo antes posible en el ciclo de vida del desarrollo de software (SDLC). Aunque muchos equipos ya utilizan herramientas de análisis estático (SAST) y dinámico (DAST) en sus pipelines de CI/CD, ¿y si pudiéramos mejorar eso? ¿Y si pudiéramos detectar los problemas justo al escribir el código, durante los commits locales o en los primeros pasos de una pipeline?

Y si quizá ya nos has visto hablar de Shift-Left, pero ahora vamos a añadir la IA.

En esta charla exploraremos cómo combinar GitHub Copilot y GitHub Advanced Security para acercar los controles de seguridad al desarrollador. A través de ejemplos prácticos, demostraremos cómo obtener feedback rápido y accionable, ayudándote a prevenir vulnerabilidades antes de que lleguen a producción.

# Demo-plan and topics

## Ordered demo
1. Copilot - Threat model
2. GitHub
	1. Dependabot
 		- Updates
	2. Secrets
		1. Push protection
		2. 🆕 panel and custom config
	3. Authentication
	4. Agentic mode to fix -> Header -> JWT
		1. Already cooked, with comments and conversation
3. Copilot
	1. Cookies
	2. Authentication -> Header -> JWT con agent
	3. Appsettings
	4. Other vulns
	5. 🆕 Lightweight: auto aprove, mode auto 
	6. 🆕 New options with Agents.md, custom instructions, chat modes...



# References
1. Addding custom instructions https://docs.github.com/en/enterprise-cloud@latest/copilot/customizing-copilot/adding-repository-custom-instructions-for-github-copilot
2. Store prompts https://code.visualstudio.com/docs/copilot/copilot-customization#_reusable-prompt-files-experimental
3. Customizing copilot instructions https://docs.github.com/en/enterprise-cloud@latest/copilot/customizing-copilot/about-customizing-github-copilot-chat-responses
	1. Use it pointing to npmjs so it can detect new versions
	2. https://github.blog/changelog/2025-07-23-github-copilot-coding-agent-now-supports-instructions-md-custom-instructions/
	3. https://docs.github.com/en/enterprise-cloud@latest/copilot/tutorials/coding-agent/get-the-best-results#adding-custom-instructions-to-your-repository
	4. https://docs.github.com/en/enterprise-cloud@latest/copilot/how-tos/configure-custom-instructions/add-repository-instructions?tool=webui
4. Security MCPs https://github.com/punkpeye/awesome-mcp-servers?tab=readme-ov-file#security
5. MCPs intro
	1. https://www.youtube.com/watch?v=5ZWeCKY5WZE 
	2. https://www.youtube.com/watch?v=sahuZMMXNpI&t=12s
6. Auto mode https://github.blog/changelog/2025-09-14-auto-model-selection-for-copilot-in-vs-code-in-public-preview/ 
7. Secrets
	1. https://github.blog/changelog/2025-08-26-the-secret-risk-assessment-is-generally-available/
	2. https://github.blog/changelog/2025-07-22-secret-scanning-adds-validity-checks-for-over-40-secret-detectors/
	3. https://github.blog/changelog/2025-08-19-secret-scanning-configuring-patterns-in-push-protection-is-now-generally-available/